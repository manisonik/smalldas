using System.Collections.Generic;
using System.Runtime.InteropServices;
using SmallDAS.Core;
using NationalInstruments.Visa;
using Ivi.Visa;
using System.Text.RegularExpressions;

namespace SmallDAS.Visa
{
    public class VisaDevice : IDevice
    {
        private ResourceManager rMgr = new ResourceManager();
        private MessageBasedSession mbSession;
        private string srcAddress = "USB0::0xF4EC::0xEE3A::SDS1MEBQ2R5823::INSTR";
        //private string srcAddress = "TCPIP0::10.0.0.242::inst1::INSTR";
        private bool connected;

        public string pkpk { get; private set; }
        public string max { get; private set; }
        public string min { get; private set; }
        public string ampl { get; private set; }
        public string top { get; private set; }
        public string vbase { get; private set; }
        public string cmean { get; private set; }
        public string mean { get; private set; }
        public string rms { get; private set; }
        public string crms { get; private set; }
        public string ovsn { get; private set; }
        public string fpre { get; private set; }
        public string ovsp { get; private set; }
        public string rpre { get; private set; }
        public string per { get; private set; }
        public string freq { get; private set; }
        public string pwid { get; private set; }
        public string nwid { get; private set; }
        public string rise { get; private set; }
        public string wid { get; private set; }
        public string duty { get; private set; }
        public string nduty { get; private set; }
        public int parameterCount { get; private set; }
        public string vdelta { get; private set; }

        public bool Initialize()
        {
            Reconnect();
            return true;
        }

        public bool IsConnected()
        {
            return connected;
        }

        public void Reconnect()
        {
            Close();
            connected = false;

            try
            { 
                mbSession = (MessageBasedSession)rMgr.Open(srcAddress);
                mbSession.RawIO.Write("*IDN?");
                mbSession.TimeoutMilliseconds = 5000;
                string result = mbSession.RawIO.ReadString();

                mbSession.RawIO.Write("*ESR?");
                result = mbSession.RawIO.ReadString();

                connected = true;
            }
            catch (Ivi.Visa.NativeVisaException e)
            {
                connected = false;
                Close();
            }
        }

        public object GetTimeDivision()
        {
            float value = 0;

            try
            {
                if (connected)
                {
                    mbSession.RawIO.Write("TDIV?");
                    string response = mbSession.RawIO.ReadString();

                    string[] s = response.Split(' ');
                    if (s[0].Equals("TDIV"))
                    {
                        value = float.Parse(s[1].TrimEnd('n', 's', 'S', '\n'));
                    }
                }
            }
            catch (COMException e)
            {
            }

            return value;
        }

        public object GetTriggerDelay()
        {
            float value = 0;

            try
            {
                if (connected)
                {
                    mbSession.RawIO.Write("TRDL?");
                    string response = mbSession.RawIO.ReadString();

                    string[] s = Regex.Replace(response, "\n", "").Split(' ');
                    if (s[0].Equals("TRDL"))
                    {
                        if (s[1].Contains("us"))
                        {
                            string number = Regex.Replace(s[1], "us", "");
                            value = (float)(float.Parse(number) * 1e-9);
                        }
                        else if (s[1].Contains("ms"))
                        {
                            string number = Regex.Replace(s[1], "ms", "");
                            value = (float)(float.Parse(number) * 1e-6);
                        }
                    }
                }
            }
            catch (COMException e)
            {
            }

            return value;
        }

        public void SetTriggerDelay(float delay)
        {
            string unit = "us";

            try
            {
                if (connected)
                {
                    if (delay % 1000 > 0)
                    {
                        delay = delay / 1000;
                        unit = "ms";
                    }

                    mbSession.RawIO.Write(string.Format("TRDL {0}{1}", delay, unit));
                }
            }
            catch (COMException e)
            {
            }
        }

        public object GetSampleRate()
        {
            float value = 0;

            try
            {
                if (connected)
                {
                    mbSession.RawIO.Write("SARA?");
                    string response = mbSession.RawIO.ReadString();

                    string[] s = response.Split(' ');
                    if (s[0].Equals("SARA"))
                    {
                        if (s[1].Contains(@"GSa"))
                        {
                            value = float.Parse(s[1].TrimEnd('G', 'S', 'a', '\n')) * 1e9f;
                        }
                        else if (s[1].Contains(@"MSa"))
                        {
                            value = float.Parse(s[1].TrimEnd('M', 'S', 'a', '\n')) * 1e6f;
                        }
                        else if (s[1].Contains(@"KSa"))
                        {
                            value = float.Parse(s[1].TrimEnd('K', 'S', 'a', '\n')) * 1e3f;
                        }
                    }
                }
            }
            catch (COMException e)
            {
            }

            return value;
        }

        public List<object> C1GetWaveFormData()
        {
            List<object> result = new List<object>();

            if (connected)
            {
                mbSession.RawIO.Write("C1:WF? dat2");

                ReadStatus status;
                byte[] response = mbSession.RawIO.Read(50000, out status);

                float div = (float)C1GetVoltageDiv();
                float off = (float)C1GetVoltageOffset();

                if (response.Length > 21)
                {
                    for (int i = 21; i < response.Length-2; i++)
                    {
                        // Calculation for waveform is CODE(DIV/25)-(OFF) = VOLT
                        float r = 0;
                        if (response[i] > 127)
                            r = response[i] - 255;
                        else
                            r = response[i];

                        float dec = r * (div / 25) - off;
                        result.Add(dec);
                    }
                }
            }

            return result;
        }

        public List<object> C2GetWaveFormData()
        {
            List<object> result = new List<object>();

            if (connected)
            {
                mbSession.RawIO.Write("C2:WF? dat2");

                ReadStatus status;
                byte[] response = mbSession.RawIO.Read(50000, out status);

                float div = (float)C2GetVoltageDiv();
                float off = (float)C2GetVoltageOffset();

                if (response.Length > 21)
                {
                    for (int i = 21; i < response.Length - 2; i++)
                    {
                        // Calculation for waveform is CODE(DIV/25)-(OFF) = VOLT
                        float r = 0;
                        if (response[i] > 127)
                            r = response[i] - 255;
                        else
                            r = response[i];

                        float dec = r * (div / 25) - off;
                        result.Add(dec);
                    }
                }
            }

            return result;
        }

        public object C1GetVoltageDiv()
        {
            float value = 0;

            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("C1:VDIV?");
                    string response = mbSession.RawIO.ReadString();

                    if (response.Contains("C1"))
                    {
                        string[] s = response.Split(' ');
                        value = float.Parse(s[1].TrimEnd('V', '\n'));
                    }
                }
                catch (COMException e)
                {
                }
            }

            return value;
        }

        public object C2GetVoltageDiv()
        {
            float value = 0;

            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("C2:VDIV?");
                    string response = mbSession.RawIO.ReadString();

                    if (response.Contains("C2"))
                    {
                        string[] s = response.Split(' ');
                        value = float.Parse(s[1].TrimEnd('V', '\n'));
                    }
                }
                catch (COMException e)
                {
                }
            }

            return value;
        }

        public object C1GetVoltageOffset()
        {
            float value = 0;

            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("C1:OFST?");
                    string response = mbSession.RawIO.ReadString();

                    if (response.Contains("C1"))
                    {
                        string[] s = response.Split(' ');
                        value = float.Parse(s[1].TrimEnd('V', '\n'));
                    }
                }
                catch (COMException e)
                {
                }
            }

            return value;
        }

        public object C2GetVoltageOffset()
        {
            float value = 0;

            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("C2:OFST?");
                    string response = mbSession.RawIO.ReadString();

                    if (response.Contains("C2"))
                    {
                        string[] s = response.Split(' ');
                        value = float.Parse(s[1].TrimEnd('V', '\n'));
                    }
                }
                catch (COMException e)
                {
                }
            }

            return value;
        }

        public void SetTimeDivision(string tdiv)
        {
            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("TDIV " + tdiv);
                }
                catch (COMException e)
                {
                }
            }
        }

        public void SetVoltageDivision(string vdiv)
        {
            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("VDIV " + vdiv);
                }
                catch (COMException e)
                {
                }
            }
        }

        public void StopAcquisition()
        {
            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("STOP");
                }
                catch (COMException e)
                {
                }
            }
        }

        public void StartAcquisition()
        {
            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("ARM");
                }
                catch (COMException e)
                {
                }
            }
        }

        public void ShowCursorHREL()
        {
            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("CRMS HREL");
                }
                catch (COMException e)
                {
                }
            }
        }

        public void ShowCursorVREL()
        {
            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("CRMS VREL");
                }
                catch (COMException e)
                {
                }
            }
        }

        public void ShowCursorAUTO()
        {
            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("CRMS AUTO");
                }
                catch (COMException e)
                {
                }
            }
        }

        public void CursorAutoMode()
        {
            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("CRAU");
                }
                catch (COMException e)
                {
                }
            }
        }

        public void HideCursor()
        {
            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("CRMS OFF");
                }
                catch (COMException e)
                {
                }
            }
        }

        public void CursorSetVoltage(int vref, int vdif)
        {
            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("C1:CRST VREF,1DIV,VDIF,1DIV");
                }
                catch (COMException e)
                {
                }
            }
        }

        public void Poll()
        {
            if (connected)
            {
                try
                {
                    mbSession.RawIO.Write("PAVA? ALL");
                    string response = mbSession.RawIO.ReadString();

                    string[] s = response.Split(' ');
                    if (s.Length > 1)
                    {
                        string[] ss = s[1].Split(',');
                        for (int i = 0; i < ss.Length; i+=2)
                        {
                            if (ss[i] == "PKPK")
                            {
                                pkpk = ss[i + 1];
                            }
                            else if (ss[i] == "MAX")
                            {
                                max = ss[i + 1];
                            }
                            else if (ss[i] == "MIN")
                            {
                                min = ss[i + 1];
                            }
                            else if (ss[i] == "AMPL")
                            {
                                ampl = ss[i + 1];
                            }
                            else if (ss[i] == "TOP")
                            {
                                top = ss[i + 1];
                            }
                            else if (ss[i] == "BASE")
                            {
                                vbase = ss[i + 1];
                            }
                            else if (ss[i] == "CMEAN")
                            {
                                cmean = ss[i + 1];
                            }
                            else if (ss[i] == "MEAN")
                            {
                                mean = ss[i + 1];
                            }
                            else if (ss[i] == "RMS")
                            {
                                rms = ss[i + 1];
                            }
                            else if (ss[i] == "CRMS")
                            {
                                crms = ss[i + 1];
                            }
                            else if (ss[i] == "OVSN")
                            {
                                ovsn = ss[i + 1];
                            }
                            else if (ss[i] == "FPRE")
                            {
                                fpre = ss[i + 1];
                            }
                            else if (ss[i] == "OVSP")
                            {
                                ovsp = ss[i + 1];
                            }
                            else if (ss[i] == "RPRE")
                            {
                                rpre = ss[i + 1];
                            }
                            else if (ss[i] == "PER")
                            {
                                per = ss[i + 1];
                            }
                            else if (ss[i] == "FREQ")
                            {
                                freq = ss[i + 1];
                            }
                            else if (ss[i] == "PWID")
                            {
                                pwid = ss[i + 1];
                            }
                            else if (ss[i] == "NWID")
                            {
                                nwid = ss[i + 1];
                            }
                            else if (ss[i] == "RISE")
                            {
                                rise = ss[i + 1];
                            }
                            else if (ss[i] == "WID")
                            {
                                wid = ss[i + 1];
                            }
                            else if (ss[i] == "DUTY")
                            {
                                duty = ss[i + 1];
                            }
                            else if (ss[i] == "NDUTY")
                            {
                                nduty = ss[i + 1];
                            }
                        }
                    }

                    // Cursor
                    mbSession.RawIO.Write("C1:CRVA? HREL");
                    response = mbSession.RawIO.ReadString();

                    string[] s2 = Regex.Split(response, ",| ");
                    if (s2.Length == 3)
                    {
                        vdelta = Regex.Replace(s2[2], "\n", "");
                    }

                    // Cursor values
                    //mbSession.RawIO.Write("C1:CRST? VREF");
                    //response = mbSession.RawIO.ReadString();


                }
                catch (COMException e)
                {
                }
            }
        }

        public List<Core.Channel> GetChannels()
        {
            List<Channel> channels = new List<Channel>();

            // GetVoltageOffset
            Channel chan = new Channel
            {
                Name = "D_OSC.OFST",
                Data = C1GetVoltageOffset,
                Units = "V",
                DataType = typeof(float)
            };
            channels.Add(chan);

            // GetVoltageDiv
            chan = new Channel
            {
                Name = "D_OSC.VDIV",
                Data = C1GetVoltageDiv,
                Units = "V",
                DataType = typeof(float)
            };
            channels.Add(chan);

            // GetWaveFormData
            chan = new Channel
            {
                Name = "D_OSC.WF",
                Data = C1GetWaveFormData,
                Units = "V",
                DataType = typeof(float)
            };
            channels.Add(chan);

            return channels;
        }

        public bool Close()
        {
            if (mbSession != null)
            {
                //mbSession.UnlockResource();
                mbSession.Dispose();
            }

            return true;
        }
    }
}

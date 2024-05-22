using System.Collections.Generic;
using System.ComponentModel;

namespace SmallDAS
{
    public class Parser : IParser
    {
        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("Name of the parser")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("Name")]       // I want to say more, than just DisplayInt
        public string Name { get; set; }

        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("sample hint1")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("Start of text (STX)")]       // I want to say more, than just DisplayInt
        public string STX { get; set; }

        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("sample hint1")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("End of text (ETX)")]       // I want to say more, than just DisplayInt
        public string ETX { get; set; }

        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("sample hint1")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("Delimiter")]       // I want to say more, than just DisplayInt
        public string Delimiter { get; set; }

        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("sample hint1")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("Terminator")]       // I want to say more, than just DisplayInt
        public string Terminator { get; set; }

        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("sample hint1")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("Commands")]       // I want to say more, than just DisplayInt
        public List<Command> Commands { get; set; } = new List<Command>();

        public void Parse()
        {

        }
    }
}

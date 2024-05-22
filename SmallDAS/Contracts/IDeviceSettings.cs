using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallDAS
{
    public interface IDeviceSettings
    {
        void Apply();
        void Reset();
        void SetParameter(string name, object value);
        object GetParameter(string name);
    }
}

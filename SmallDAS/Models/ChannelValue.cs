using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SmallDAS
{
    public class ChannelValue
    {
        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("sample hint1")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("Text")]       // I want to say more, than just DisplayInt
        public string Text { get; set; }

        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("sample hint1")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("Value")]       // I want to say more, than just DisplayInt
        public double Value { get; set; }
    }
}

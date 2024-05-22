using System.ComponentModel;

namespace SmallDAS
{
    public class Channel : IChannel
    {
        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("sample hint1")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("Id")]       // I want to say more, than just DisplayInt
        public int Id { get; set; }

        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("sample hint1")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("Name")]       // I want to say more, than just DisplayInt
        public string Name { get; set; }

        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("sample hint1")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("Description")]       // I want to say more, than just DisplayInt
        public string Description { get; set; }

        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("sample hint1")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("Recording Mask")]       // I want to say more, than just DisplayInt
        public int RecordingMask { get; set; }

        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("sample hint1")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("Type")]       // I want to say more, than just DisplayInt
        public ChannelType Type { get; set; }

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

        [Browsable(true)]                         // this property should be visible
        [ReadOnly(false)]                          // but just read only
        [Description("sample hint1")]             // sample hint1
        [Category("Attribute")]                   // Category that I want
        [DisplayName("Parser")]       // I want to say more, than just DisplayInt
        public int Parser { get; set; }
    }
}

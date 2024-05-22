using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace SmallDAS
{
    public interface ICommand
    {
        string Name { get; set; }
        string Format { get; set; }
    }
}

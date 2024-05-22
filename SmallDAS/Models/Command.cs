using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallDAS
{
    public class Command : ICommand
    {
        private string _name;
        private string _format;

        public string Name 
        { 
            get { return _name; } 
            set { _name = value; }
        }

        public string Format
        {
            get { return _format; }
            set { _format = value; }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallDAS
{
    public interface IProtocol
    {
        void Process(string message);
    }
}

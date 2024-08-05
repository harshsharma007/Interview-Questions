using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Interface
{
    interface IPerson
    {
        string Name { get; set; }
        IAddress Address { get; set; }
    }
}

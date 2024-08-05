using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Interface
{
    interface IParcel
    {
        IPerson Sender { get; set; }
        IPerson Receipient { get; set; }
        double Weight { get; set; }
        double Value { get; set; }
    }
}

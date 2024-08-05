using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Interface
{
    interface IAddress
    {
        string Street { get; set; }
        int HouseNumber { get; set; }
        string PostalCode { get; set; }
        string City { get; set; }
    }
}

using DemoLibrary.Departments;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Interface
{
    interface IDepartment
    {
        IList<IParcel> Parcels { get; set; }
        DepartmentType Type { get; set; }
    }
}

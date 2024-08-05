using DemoLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Departments
{
    class Department : IDepartment
    {
        public IList<IParcel> Parcels { get; set; }
        public DepartmentType Type { get; set; }

        public void LoadData()
        {

        }
    }
}

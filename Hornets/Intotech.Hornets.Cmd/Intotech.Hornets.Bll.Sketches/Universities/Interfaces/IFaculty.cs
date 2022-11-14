﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.Universities.Interfaces
{
    public interface IFaculty<TStudent> where TStudent : IStudent
    {
        string GetFaculty();

        bool AddStudent(TStudent student);
    }
}

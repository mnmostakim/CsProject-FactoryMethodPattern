﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Monthly_03_Project.Factories
{
    public interface IObjectFactory
    {
        T Create<T>(params object[] args) where T : class;
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationClass
{
    public abstract class AbstractLecturer
    {
        public abstract void Save();

        public abstract void Update();
    }
}

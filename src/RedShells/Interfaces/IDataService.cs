﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RedShells.Interfaces
{
    public interface IDataService
    {
        void Create(Workspace workspace);

        Workspace Get(string key);

        void Update(Workspace workspace);
    }
}

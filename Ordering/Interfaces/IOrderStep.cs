﻿using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.ProcessManagement
{
    public interface IOrderStep<T>
    {
        IOrderQueue<T> OrderQueue { get; set; }

    }
}
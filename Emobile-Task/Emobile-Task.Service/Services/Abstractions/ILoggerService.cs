﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emobile_Task.Service.Services.Abstractions
{
    public interface ILoggerService
    {
        void InfoPostedData(string message, object obj);
    }
}

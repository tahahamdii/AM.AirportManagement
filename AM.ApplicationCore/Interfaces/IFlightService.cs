﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    internal interface IFlightService
    {
        void ShowFlights(string filterType, string filterValue);
    }
}

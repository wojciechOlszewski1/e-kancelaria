﻿using GusApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ObslugaGus gus = new ObslugaGus();

            gus.ApiKey = "twojKluczApi";
            var podmiot = gus.PobierzDanePodmiotu("numernip");
        }
    }
}

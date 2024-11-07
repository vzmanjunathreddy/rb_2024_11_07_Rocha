﻿using ConsoleApp1.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class IceCreamModel
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public EnumTypeIceCream TypeIceCream { get; set; }
    }
}

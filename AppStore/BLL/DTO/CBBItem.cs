﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStore.BLL.DTO
{
    public class CBBItem
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
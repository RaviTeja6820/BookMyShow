﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models.DTO
{
    public class SeatDTO
    {
        public int ID { get; set; }

        public int ScreenID { get; set; }

        public string Code { get; set; }

        public int Active { get; set; }
    }
}

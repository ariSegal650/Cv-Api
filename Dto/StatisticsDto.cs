using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Dto
{
    public class StatisticsDto
    {
         public int? clicks { get; set; }

        public string? city { get; set; }

        public bool? download { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularTutorial.Models
{
    public class Sprint
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public bool IsCompleted { get; set; }
        public double Profit
        {
            get
            {
                if (Cost == 0)
                    return 0;

                return (Revenue / (double)Cost) * 100;
            }
        }
    }
}
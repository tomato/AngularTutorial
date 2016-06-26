using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularTutorial.Models
{
    public class Project
    {

        public Project(IEnumerable<Sprint> sprints)
        {
            this.Sprints = sprints;
        }

        public double TotalRevenue
        {
            get
            {
                return CompletedSprints.Sum(s => s.Revenue);
            }
            set { }

        }

        public double TotalCost
        {
            get
            {
                return CompletedSprints.Sum(s => s.Cost);
            }
            set { }

        }

        public IEnumerable<Sprint> Sprints { get; set; }

        private IEnumerable<Sprint> CompletedSprints
        {
            get { return Sprints.Where(s => s.IsCompleted); }
        }

       
    }
}
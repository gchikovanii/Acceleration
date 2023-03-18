using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    public class Country
    {
        public Name name { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public float[] latlng { get; set; }
        public double area { get; set; }
        public int population { get; set; }
    }
}

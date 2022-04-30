using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSProject
{
    public class HistogramData
    {
        //public List<int> ColorValues { get; set; } // create 1 instance of HistogramData per RGB channel
        public List<int> Frequencies { get; set; } // basically a hashmap with color value as key, frequency as value
        public HistogramData()
        {
            //ColorValues = Enumerable.Range(0, 255).ToList();
            Frequencies = new List<int>(new int[256]);
        }
    }
}

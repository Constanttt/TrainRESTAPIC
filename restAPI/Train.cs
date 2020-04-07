using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restAPI
{
    public class Train
    {
        public Double prix { get; set; }
        public Dictionary<string, Double> getDevises()
        {
            Dictionary<string, Double> h = new Dictionary<string, Double>();
            h.Add("EUR", 1);
            h.Add("GBP", 0.8827);
            h.Add("AUD", 1.7592);
            h.Add("USD", 1.0916);
            return h;
        }
    }
}
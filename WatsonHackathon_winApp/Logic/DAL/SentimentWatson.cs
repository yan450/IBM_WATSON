using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DAL
{
    public class SentimentWatson
    {
        public int score { get; set; }

        public decimal comparative { get; set; }

        public List<String> tokens { get; set; }

        public List<String> words { get; set; }

        public List<String> positive { get; set; }

        public List<String> negative { get; set; }
    }
}

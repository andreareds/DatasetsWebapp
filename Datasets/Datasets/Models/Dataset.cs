using System;
using System.Collections.Generic;

namespace Datasets.Models
{
    public class Dataset
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Filename { get; set; }

        public List<Keyword> Keywords { get; set; }
        public string Url { get; set; }
    }
}

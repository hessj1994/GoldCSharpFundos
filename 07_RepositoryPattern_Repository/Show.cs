using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    class Show : StreamingContent
    {
        public int SeasonCount { get; set; }
        public int EpisodeCount { get; set; }
        public double AverageRunTime { get; set; }
        public List<Episode> Epiodes { get; set; }//make episode object, add to this list
    }

    public class Episode//not inheriting, coming from the list Episodes, wont conflict with other Title object
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
    }
}

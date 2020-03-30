using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    class MovieAndShowRepo : StreamingContentRepository//private and readonly? has to be public when being referenced in program UI, would that cause end user issues?
    {
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {//what if there waas a movie and show with the same name? ex Limitless
                    return (Show)content;//is of type streamingcontent, content = streamingcontent, c# is strongtyped language. returning show, cant return content, have to cast
                }//bc show is of type streamingcontent object, can be casted. cant just return content;
            }
            return null;
        }//get movieby title, get all movies
        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show)
                {
                    allShows.Add((Show)content);
                }
            }
            return allShows;
        }
    }
}
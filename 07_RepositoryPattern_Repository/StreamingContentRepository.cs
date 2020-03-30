using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{//class library, private and readonly?
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();//CRUD CREATE READ UPDATE DELETE

        //show content by title

        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count();
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;//dont have to return in create method, could be void
            //_contentDirectory.Add(content);
        }

        public List<StreamingContent> GetContent()
        {
            return _contentDirectory;
        }
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Movie))
                {
                    return (Movie)content;
                }
            }

            return null;
        }

        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add((Movie)content);
                }
            }
            return allMovies;
        }

        public bool UpdateCurrentContent(string title, StreamingContent newContent)
        {
            StreamingContent oldContent = GetShowByTitle(title);
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.IsFamilyFriendly = newContent.IsFamilyFriendly;
                oldContent.ReleaseDate = newContent.ReleaseDate;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                oldContent.RunTimeInMin = newContent.RunTimeInMin;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteCurrentContent(string title)
        {
            StreamingContent foundContent = GetShowByTitle(title);
            bool deletedContent = _contentDirectory.Remove(foundContent);
            return deletedContent;
        }
    }
}

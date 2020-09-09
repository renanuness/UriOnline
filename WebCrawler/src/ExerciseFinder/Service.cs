using Infra.FileHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCrawler.App;

namespace ExerciseFinder
{
    public class Service
    {
        Crawler _webCrawler;
        FolderHandler _folderHandler;

        public Service()
        {
             _webCrawler = new Crawler();
            _folderHandler = new FolderHandler();
        }
        public async Task Start()
        {
            var exercisesSite = await _webCrawler.StartCrawlerAsync();

            var exerscisesDone = _folderHandler.GetExercisesDone();
        }

        //private List<string> GetExercisesToDo()
        //{

        //}
    }
}

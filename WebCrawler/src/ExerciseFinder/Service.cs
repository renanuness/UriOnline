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

            var exercisesToDo = GetExercisesToDo(exercisesSite, exerscisesDone);

            foreach (var exercise in exercisesToDo)
                Console.Write("{0}\n", exercise);

            Console.ReadLine();
        }

        private List<string> GetExercisesToDo(IEnumerable<string> exercisesSite, IEnumerable<string> exercisesDone)
        {
            List<string> exercisesToDo = new List<string>();

            foreach(var exerciseSite in exercisesSite)
            {
                if (!exercisesDone.Contains(exerciseSite))
                    exercisesToDo.Add(exerciseSite);
            }

            return exercisesToDo;
        }
    }
}

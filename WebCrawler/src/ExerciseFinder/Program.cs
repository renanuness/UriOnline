using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCrawler.App;

namespace ExerciseFinder
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Service service = new Service();
            await service.Start();

        }
    }
}

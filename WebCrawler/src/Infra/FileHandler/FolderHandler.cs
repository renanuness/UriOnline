using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Infra.FileHandler
{
    public class FolderHandler
    {
        public IEnumerable<string> GetExercisesDone()
        {
            List<string> exercisesDone = new List<string>();
            var path = @"C:\Users\renan.silva\Documents\repos\UriOnline\iniciante";
            var directories = Directory.GetDirectories(path).Where(dir => Directory.GetDirectories(path+@"\"+dir).Contains("csharp"));

            return directories;
        }
    }
}

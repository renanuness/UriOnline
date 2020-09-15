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
            var exercisesFolders = GetExercisesFolder();

            List<string> exercises = new List<string>();
            foreach (var exercise in exercisesFolders)
                exercises.Add(GetExerciseName(exercise));

            return exercises;
        }

        private string GetExerciseName(string exercise)
        {
            string[] names = exercise.Split('\\');

            return names.Last().Replace("ex","");
        }

        private IEnumerable<string> GetExercisesFolder()
        {
            List<string> exercisesDone = new List<string>();
            var path = @"C:\Users\tp.renan.silva\Documents\repos\UriOnline\iniciante\csharp";
            var directories = Directory.GetDirectories(path);

            return directories;
        }
    }
}

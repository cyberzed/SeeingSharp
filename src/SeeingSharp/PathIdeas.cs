using System.IO;

namespace SeeingSharp
{
    public class PathIdeas
    {
        public string BadPathing(string path, string filename)
        {
            if (path.EndsWith("\\"))
            {
                return path + filename;
            }

            return path + "\\" + filename;
        }

        public string AwesomePathToHeaven(string path, string filename)
        {
            return Path.Combine(path, filename);
        }
    }
}
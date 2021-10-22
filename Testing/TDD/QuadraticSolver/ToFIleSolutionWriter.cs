using System.IO;

namespace QuadraticSolver
{
    internal class ToFIleSolutionWriter : ISolutionWriter
    {
        public bool IsExists(string path)
        {
            return File.Exists(path);
        }

        public void Write(string result, string path, bool append = false)
        {
            if (append)
            {
                File.AppendAllText(path, result);
                return;
            }

            File.WriteAllText(path, result);
        }
    }
}
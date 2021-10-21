namespace QuadraticSolver
{
    public interface ISolutionWriter
    {
        bool IsExists(string path);

        void Write(string result, string path, bool append);
    }
}
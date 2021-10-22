namespace Equation

{
    public interface IFileWrapper
    {
        string ReadDataFromFile(string filePath);
        bool CheckFileExists(string filePath);
        void WriteInFile(string filePath, string v);
    }
}
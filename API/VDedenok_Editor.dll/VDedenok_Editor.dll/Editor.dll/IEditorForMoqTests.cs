namespace Editor.dll
{
    public interface IEditorForMoqTests
    {
       
        void CopyFile(string fileName, string text);
        void CopyFileToStorage(string path);
        int FindAndReplace(string fileName, string searchText, string replaceText);
        string[] GetFileNamesInStorage();
        string[] SearchParagraphs(string fileName, string searchText);
    }
}
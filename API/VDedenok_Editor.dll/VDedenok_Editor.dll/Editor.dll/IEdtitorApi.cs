namespace Editor.dll
{
    public interface IEdtitorApi
    {
        void CopyFileToStorage(string path);
        int FindAndReplace(string fileName, string searchText, string replaceText);
        string GetFileNamesInStorage();
        string SearchParagraphs(string fileName, string searchText);
    }
}
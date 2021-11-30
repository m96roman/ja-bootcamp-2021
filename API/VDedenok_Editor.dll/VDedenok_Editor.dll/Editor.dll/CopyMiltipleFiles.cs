using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Editor.dll
{
    public class CopyMiltipleFiles
    {
        EdtitorApi editor = new EdtitorApi();

        public string[] CopyAndShowCreated(List<string> pathes)
        {
            string[] listOfCreatedFiles = editor.GetFileNamesInStorage();


            return listOfCreatedFiles;
        }
    }

}

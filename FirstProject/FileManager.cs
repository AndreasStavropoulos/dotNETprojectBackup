using System.Collections.Generic;
using System.IO;

namespace FirstProject
{
    internal class FileManager
    {
        public void WriteDataToFile(string textToWriteFile, string path)
        {
            using StreamWriter write = new StreamWriter(path, true);
            write.WriteLine(textToWriteFile);
        }

        public void DeleteFile(string file)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }
    }
}
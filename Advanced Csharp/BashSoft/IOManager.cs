using System.Collections.Generic;
using static System.IO.Directory;
using static BashSoft.OutputWriter;

namespace BashSoft
{
    public static class IOManager
    {
        public static void TraverseDirrectory(string path)
        {
            WriteEmptyLine();
            int initialIdentation = path.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(path);

            while (subFolders.Count != 0)
            {
                string currentPath = subFolders.Dequeue();
                int identation = currentPath.Split('\\').Length - initialIdentation;

                WriteMessageOnNewLine($"{new string('-', identation)}{currentPath}");

                foreach (string directoryPath in GetDirectories(currentPath))
                {
                    TraverseDirrectory(directoryPath);
                }
            }
        }
    }
}

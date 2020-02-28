using System.IO;
using System.Collections.Generic;

namespace ReadTxt.Services
{
    public static class FilesServices
    {
        public static List<string> GetFileLines(Stream inputArquivo)
        {
            var FileLines = new List<string>();

            using (StreamReader leitor = new StreamReader(inputArquivo))
            {
                do
                {
                    var next = leitor.ReadLine();
                    FileLines.Add(next);
                } while (leitor.Peek() != -1);
            }

            return FileLines;
        }
    }
}

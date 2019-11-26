using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TestProject
{
    class DirectoryWorker
    {
        public string DefaultDirectoryToLoad;
        public string DefaultDirectoryToSave;
        public int Top;
        private List<OutFile> OutFiles;
        public DirectoryWorker()
        {
            DefaultDirectoryToLoad = "input";
            DefaultDirectoryToSave = "output";
            Top = 10;
        }
        private void CheckDirectory()
        {
            if (!Directory.Exists(DefaultDirectoryToLoad))
                throw new Exception("Директория для считывания не найдена!");

            if (!Directory.Exists(DefaultDirectoryToSave))
                throw new Exception("Директория для записи не найдена!");
        }
        public void CreateOutFile()
        {
            CheckDirectory();

            OutFiles = new List<OutFile>();

            DirectoryInfo dir = new DirectoryInfo(DefaultDirectoryToLoad);
            foreach (var item in dir.GetFiles("*.infile"))
            {
                OutFile Temp_OutFile = new OutFile();
                Temp_OutFile.FileName = item.Name.Replace(item.Extension, "");
                using (StreamReader sr = new StreamReader(item.FullName))
                {
                    string Line;
                    while ((Line = sr.ReadLine()) != null)
                    {
                        Temp_OutFile.ParseText(Line);
                    }
                }
                OutFiles.Add(Temp_OutFile);
            }
        }

        public void SaveFiles()
        {
            foreach (OutFile Out in OutFiles)
            {
                string ToSave = Out.GetJson(Top);
                using (FileStream fstream = new FileStream(DefaultDirectoryToSave + "\\" + Out.FileName + ".outfile", FileMode.Create))
                {
                    byte[] array = System.Text.Encoding.UTF8.GetBytes(Out.GetJson(Top));
                    fstream.Write(array, 0, array.Length);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsCollections
{
    class Woords
    {
        public void Words(string Path)
        {
            var Errors = new List<string>() { "хоршо","хорашо","харашо", "отл", "атлична"};
            string[] array1 = Directory.GetFiles(Path, "*.txt");
            for(int Index = 0; Index < Errors.Count;++Index)
            {
                if (Errors[Index] == "хоршо" || Errors[Index] == "хорашо" || Errors[Index] == "харашо")
                {
                    string Word = Errors[Index];
                    foreach (string File in array1)
                    {
                        string str = string.Empty;
                        using (StreamReader reader = System.IO.File.OpenText(File))
                        {
                            str = reader.ReadToEnd();
                        }
                        str = str.Replace(Word, "хорошо");

                        using (StreamWriter file = new StreamWriter(File))
                        {
                            file.Write(str);
                        }
                    }
                }
                if (Errors[Index] == "отл" || Errors[Index] == "атлична")
                {
                    string Word = Errors[Index];
                    foreach (string File in array1)
                    {
                        string str = string.Empty;
                        using (StreamReader reader = System.IO.File.OpenText(File))
                        {
                            str = reader.ReadToEnd();
                        }
                        str = str.Replace(Word, "отлично");

                        using (StreamWriter file = new StreamWriter(File))
                        {
                            file.Write(str);
                        }
                    }
                }

            }   

        }
    }
}

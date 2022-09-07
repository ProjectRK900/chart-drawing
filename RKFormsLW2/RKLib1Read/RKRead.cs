using System;
using System.Collections.Generic;
using System.IO;

namespace RKLib1Read
{
    public class RKRead
    {
        private string filepath;
        private string filename;
        private string filetype;
        private string function;
        private string datatype;
        private List<double> xval;
        private List<double> yval;

        public RKRead(string path)
        {
            if (path.Split('.')[1] == "txt")
            {
                filepath = path;
                string[] arr = filepath.Replace("\\", ".").Split('.');
                filename = arr[arr.Length - 2];
                filetype = arr[arr.Length - 1];

                datatype = null;
                xval = new List<double>();
                yval = new List<double>();

                string[] lines = File.ReadAllLines(filepath);
                if (lines.Length > 1)
                {
                    datatype = "xy";
                    string[] str = lines[0].Split(' ');
                    for (int i = 0; i < str.Length || i < 7; i++)
                    {
                        try
                        {
                            xval.Add(Double.Parse(str[i]));
                        }
                        //catch { xval.Add(Double.Parse((i + 1).ToString())); }
                        catch { }

                    }
                    str = lines[1].Split(' ');
                    for (int i = 0; i < str.Length || i < 7; i++)
                    {
                        try
                        {
                            yval.Add(Double.Parse(str[i]));
                        }
                        //catch { yval.Add(Double.Parse((i + 1).ToString())); }
                        catch { }
                    }

                    if (xval.Count < 7)
                    {
                        for (int i = xval.Count - 1; i < 7; i++)
                            xval.Add(i + 1);
                    }

                    if (yval.Count < 7)
                    {
                        for (int i = yval.Count - 1; i < 7; i++)
                            yval.Add(i + 1);
                    }
                }
                else if (lines.Length == 1)
                {
                    datatype = "function";
                    function = File.ReadAllText(filepath);
                }
                else
                    throw new Exception("File is broken for this program");
            }
            else
                throw new Exception("Selected file is not .txt");
        }
    
        public string getfilename() {  return filename; }
        public string getfilepath() { return filepath; }
        public string getfiletype() { return filetype; }
        public string getdatatype() { return datatype;  }
        public string getfunction()
        {
            if (datatype == "function")
                return function;
            else
                return null;
        }
        public List<double> getX()
        {
            if (datatype == "xy")
                return xval;
            else
                return new List<double>();
        }
        public List<double> getY()
        {
            if (datatype == "xy")
                return yval;
            else
                return new List<double>();
        }
    }
}

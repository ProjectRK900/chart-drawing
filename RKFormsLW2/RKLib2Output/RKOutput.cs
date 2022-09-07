using System.Collections.Generic;
using System.IO;

namespace RKLib2Output
{
    public class RKOutput
    {
        public static void writeXYinFile(List<string> x, List<string> y, string path)
        {
            string data = x[0];
            for (int i = 1; i < x.Count; i++)
                data += " " + x[i];

            data += "\n";
            File.AppendAllText(path, data);

            data = y[0];
            for (int i = 1; i < y.Count; i++)
                data += " " + y[i];

            File.AppendAllText(path, data);
        }
    }
}

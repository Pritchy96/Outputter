using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outputter
{
    class Program
    {
        static void Main(string[] args)
        {     
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location.ToString());
            string[] log = Directory.GetFiles(path, ".", SearchOption.AllDirectories);
            File.WriteAllLines(path + "\\Output.txt", log);
        }
    }
}

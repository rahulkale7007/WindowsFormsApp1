using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Percentage { get; set; }
    }
}

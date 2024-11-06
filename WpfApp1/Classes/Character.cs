using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    public struct Equipment
    {
        public string Name {  get; set; }
    }
    public class Character
    {
        public string Name { get; set; }
        public string ClassName { get; set; }
        public bool IsMale { get; set; } = true;

    }
}

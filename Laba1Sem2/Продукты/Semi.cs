using Laba1Sem2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semi
{
    public class DumplingsMeat : ISemiFinished
    {
        public string Name { get; set; }
        public bool Proteins => true;
        public bool Fats => false;
        public bool Carbon => false;
        public DumplingsMeat()
        {
            Name = "Пельмени";
        }
    }
    public class Cheburek : ISemiFinished
    {
        public string Name { get; set; }
        public bool Proteins => false;
        public bool Fats => true;
        public bool Carbon => false;
        public Cheburek()
        {
            Name = "Чебурек";
        }
    }
    public class DumplingBerries : ISemiFinished
    {
        public string Name { get; set; }
        public bool Proteins => false;
        public bool Fats => false;
        public bool Carbon => true;
        public DumplingBerries()
        {
            Name = "Замороженные Ягодки";
        }
    }
}

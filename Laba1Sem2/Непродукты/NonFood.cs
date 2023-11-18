using Laba1Sem2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonFood
{
    public class NoteBook : IThing
    {
        public string Name { get; set; }
        public NoteBook() 
        {
            this.Name = "Ноутбук";
        }
    }
    public class Pen : IThing
    {
        public string Name { get; set; }
        public Pen()
        {
            this.Name = "Ручка";
        }
    }
}

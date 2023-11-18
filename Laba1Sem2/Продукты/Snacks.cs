using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba1Sem2;

namespace Snack
{
    public class ChocolateBar : ISnacks
    {
        public string Name { get; set; }
        public bool Proteins => false;
        public bool Fats => false;
        public bool Carbon => true;
        public ChocolateBar()
        {
            Name = "Чоколадка";
        }
    }
    public class Crisps : ISnacks
    {
        public string Name { get; set; }
        public bool Proteins => false;
        public bool Fats => true;
        public bool Carbon => false;
        public Crisps()
        {
            Name = "Чипсеки";
        }
    }
    public class BalykCheese : ISnacks
    {
        public string Name { get; set; }
        public bool Proteins => true;
        public bool Fats => false;
        public bool Carbon => false;
        public BalykCheese()
        {
            Name = "Сыр Косичка";
        }
    }
}

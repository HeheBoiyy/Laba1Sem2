using Laba1Sem2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthy
{
    public class Chicken : IHealthyFood
    {
        public string Name { get; set; }
        public bool Proteins => true;
        public bool Fats => false;
        public bool Carbon => false;
        public Chicken()
        {
            Name = "Курица";
        }
    }
    public class OliveOil : IHealthyFood
    {
        public string Name { get; set; }
        public bool Proteins => false;
        public bool Fats => true;
        public bool Carbon => false;
        public OliveOil()
        {
            Name = "Оливковое масло";
        }
    }
    public class Fruit : IHealthyFood
    {
        public string Name { get; set; }
        public bool Proteins => false;
        public bool Fats => false;
        public bool Carbon => true;
        public Fruit()
        {
            Name = "Фрукты";
        }
    }
}

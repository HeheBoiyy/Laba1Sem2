using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Sem2
{
    public interface IThing
    {
        public string Name { get; set; }
    }
    public interface IFood : IThing
    {
        bool Proteins { get; }
        bool Fats { get; }
        bool Carbon { get; }
    }
    public interface ISnacks : IFood
    {

    }
    public interface IHealthyFood : IFood 
    { 

    }
    public interface ISemiFinished : IFood
    {

    }
}

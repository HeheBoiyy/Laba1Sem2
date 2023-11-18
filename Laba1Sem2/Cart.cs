using Healthy;
using Semi;
using Snack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Sem2
{
    public class Cart<T> : IEnumerable where T : IFood
    {
        private List<IFood> FoodStuffs = new List<IFood>();
        public void Balance()
        {
            if (FoodStuffs.Count == 0)
            {
                MessageBox.Show("Ваша корзина пуста \n Добавьте продуктов а затем используйте балансировку");
            }
            int protein = 0;
            int carbon = 0;
            int zhir = 0;
            //bool Snacks = GetfilterSnacks(FoodStuffs);
            //bool Semi = GetfilterSemi(FoodStuffs);
            //bool Healty = GetfilterHealty(FoodStuffs);
            foreach (var item in FoodStuffs)
            {
                if (item.Fats)
                {
                    protein++;
                }
                else if (item.Carbon)
                {
                    carbon++;
                }
                else { zhir++; }
            }
            if (protein > 0 & carbon > 0 & zhir > 0)//Корзина уже сбалансирована
            {
                MessageBox.Show("Ваша корзина уже сбалансированная!");
            }
            if (protein > 0 & carbon == 0 & zhir == 0) 
            {
                FoodStuffs.Add(new Crisps());
                FoodStuffs.Add(new DumplingBerries());
                MessageBox.Show("Ваша корзина сбалансирована");
            }
            if (protein == 0&carbon>0 & zhir == 0)
            {
                FoodStuffs.Add(new BalykCheese());
                FoodStuffs.Add(new Cheburek());
                MessageBox.Show("Ваша корзина сбалансирована");
            }
            if (protein == 0 & carbon == 0 & zhir > 0)
            {
                FoodStuffs.Add(new Chicken());
                FoodStuffs.Add(new ChocolateBar());
                MessageBox.Show("Ваша корзина сбалансирована");
            }
            if (protein > 0 & carbon > 0 & zhir == 0) 
            {
                FoodStuffs.Add(new Cheburek());
                MessageBox.Show("Ваша корзина сбалансирована");
            }
            if (protein ==0 & carbon > 0 & zhir  >0) 
            {
                FoodStuffs.Add(new DumplingsMeat());
                MessageBox.Show("Ваша корзина сбалансирована");
            }
            if (protein > 0 & carbon == 0 & zhir > 0) 
            {
                FoodStuffs.Add(new Fruit());
                MessageBox.Show("Ваша корзина сбалансирована");
            }
        }
        public void Add(T item)
        {
            FoodStuffs.Add(item);
        }
        public void Add(string str,List<IThing> things)
        {
            foreach (var item in things)
            {
                if (item.Name == str & item.Name!="Ноутбук" & item.Name != "Ручка")
                {
                    FoodStuffs.Add((IFood)item);
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return FoodStuffs.GetEnumerator();
        }
        /*
        public bool GetfilterSnacks(List<IFood> cart)
        {
            int Snacks = 0;
            int Semi = 0;
            int Helthy = 0;
            foreach (var item in FoodStuffs)
            {
                if (item is ISnacks)
                {
                    Snacks += 1;
                }
                else if (item is ISemiFinished)
                {
                    Semi += 1;
                }
                else if ( item is IHealthyFood)
                {
                    Helthy += 1;
                }
            }
            if (Snacks > 1)
            {
                return true;
            }
            return false;
        }
        public bool GetfilterSemi(List<IFood> cart)
        {
            int Snacks = 0;
            int Semi = 0;
            int Helthy = 0;
            foreach (var item in FoodStuffs)
            {
                if (item is ISnacks)
                {
                    Snacks += 1;
                }
                else if (item is ISemiFinished)
                {
                    Semi += 1;
                }
                else if (item is IHealthyFood)
                {
                    Helthy += 1;
                }
            }
            if (Semi > 1)
            {
                return true;
            }
            return false;
        }
        public bool GetfilterHealty(List<IFood> cart)
        {
            int Snacks = 0;
            int Semi = 0;
            int Helthy = 0;
            foreach (var item in FoodStuffs)
            {
                if (item is ISnacks)
                {
                    Snacks += 1;
                }
                else if (item is ISemiFinished)
                {
                    Semi += 1;
                }
                else if (item is IHealthyFood)
                {
                    Helthy += 1;
                }
            }
            if (Helthy>0)
            {
                return true;
            }
            return false;
        }
    }
    */
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sub7PAW
{
    public class ComandaPizza : ICustomizabil, ICloneable
    {
        private string nume;
        private string blat;
        private int durataRealizare;
        private List<Topping> topping;
        private const float costBaza = 20f;

        public string Nume { get => nume; set => nume = value; }
        public int Durata { get => durataRealizare; set => durataRealizare = value; }
        public string Blat { get => blat; set => blat = value; }
        public List<Topping> Toppings => topping;

        public ComandaPizza(string nume, string blat, int durataRealizare)
        {
            this.nume = nume;
            this.blat = blat;
            this.durataRealizare = durataRealizare;
            topping = new List<Topping>();
        }

        public ComandaPizza(string nume, string blat, int durataRealizare, List<Topping> topping):this(nume, blat, durataRealizare)
        {
            this.topping = topping;
        }

        public Topping this[int index]
        {
            get { if (index > 0 && index < topping.Count) return topping[index]; return null; }
            set { if (index > 0 && index < topping.Count) topping[index] = value; }
        }

        public float CalculCostPizza()
        {
            float total = 0f;
            foreach(var item in topping)
            {
                total += item.Pret * item.Cantitate;
            }
            return total + costBaza;
        }

        public object Clone()
        {
            var toppings = new List<Topping>();
            foreach (var item in topping)
            {
                var topping = new Topping(item.Denumire, item.Pret, item.Cantitate, item.Cod);
                toppings.Add(topping);
            }
            var ComandaPizza = new ComandaPizza(nume, blat, durataRealizare, toppings);
            return ComandaPizza;
        }

        public static ComandaPizza operator +(ComandaPizza a, Topping t)
        {
           a.topping.Add(t);
           return a;
        }

        public static bool operator <(ComandaPizza cp1, ComandaPizza cp2 )
        {
            return cp1.CalculCostPizza() < cp2.CalculCostPizza();
        }

        public static bool operator >(ComandaPizza cp1, ComandaPizza cp2)
        {
            return cp1.CalculCostPizza() > cp2.CalculCostPizza();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Nume: {nume} Durata: {durataRealizare}");
            if(topping.Count > 0)
            {
                sb.Append(" Topping-uri: \n");
            }
            topping.ForEach(top => sb.Append(top.ToString() + Environment.NewLine));
            return sb.ToString();
        }
    }
}

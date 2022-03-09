using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public class PizzaRepository : IService
    {

        List<Pizza> pizzas = new List<Pizza>();

        public PizzaRepository()
        {
            pizzas.Add(new Pizza { Name="Pizza 1" , PreparationTime = "1", BakingTime = "1" ,
                                   CuttingTime ="1" , BoxingTime = "1"
            });
            
            pizzas.Add(new Pizza { Name="Pizza 2" , PreparationTime = "2", BakingTime = "2",
                                   CuttingTime ="2", BoxingTime = "2"
            });
            pizzas.Add(new Pizza { Name="Pizza 3" , PreparationTime = "3", BakingTime = "3" ,
                                   CuttingTime ="3", BoxingTime = "3"
            });

        }

        public List<Pizza> GetAllPizza()
        {
            foreach (Pizza p in pizzas)
            {
               
                    Console.WriteLine("Name = {0}, PreparationTime = {1}, BakingTime = {2} , CuttingTime = {3} , BoxingTime = {4}",
                        p.Name, p.PreparationTime, p.BakingTime,
                        p.CuttingTime, p.BoxingTime);
            }
            return pizzas;
        }

        public Pizza GetPizza(string name)
        {
            foreach (Pizza p in pizzas)
            {
                if (p.Name == name)
                {
                    Console.WriteLine("Name = {0}, PreparationTime = {1}, BakingTime = {2} , CuttingTime = {3} , BoxingTime = {4}", 
                        p.Name, p.PreparationTime,p.BakingTime,
                        p.CuttingTime,p.BoxingTime);
                    return p;
                }
                else continue;
            }
            return null;
        }


    }
}

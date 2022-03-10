# pizza Project Test
### My name is Rami Abboud.
### Thank you " EXACT " for this exciting test, it was fun.
### hope you like my code.
# Demo
<h1>
<p align="center"><img width=1000 src="https://github.com/ramiabboud/pizza/blob/master/pics/3333.PNG"></p>
</h1>

# Iservice interface
```c#
 public interface IService
    {
        Pizza GetPizza( string name);
        List<Pizza>  GetAllPizza();
    }
```     

# PizzaRepo
```c#
  public class PizzaRepository : IService
    {

        List<Pizza> pizzas = new List<Pizza>();

        public PizzaRepository()
        {
            pizzas.Add(new Pizza { Name="Pepperoni" , PreparationTime = "2 min", BakingTime = "5 min" ,
                                   CuttingTime ="6 sec" , BoxingTime = "5 sec"
            });
            
            pizzas.Add(new Pizza { Name="Margarita" , PreparationTime = "1 min", BakingTime = "4 min",
                                   CuttingTime ="6 sec", BoxingTime = "5 sec"
            });
            pizzas.Add(new Pizza { Name="Mashrooms" , PreparationTime = "3", BakingTime = "6 min" ,
                                   CuttingTime ="6 sec", BoxingTime = "5 sec"
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
```
### BusinessLogicService
```c#
public class BusinessLogicService
    {
        private IService iservice;

        public BusinessLogicService()
        {
            IService _iservice = new PizzaRepository();
            this.iservice = _iservice;
            this.iservice.GetAllPizza();

        }

        public void menuService(string pizzaName)
        {
            this.iservice.GetPizza(pizzaName);
        }

    }
```

















using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
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
}

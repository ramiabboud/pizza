using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    public interface IService
    {
        Pizza GetPizza( string name);
        List<Pizza>  GetAllPizza();

        
    }
}

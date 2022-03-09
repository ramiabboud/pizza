

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Choose which Pizza Do want from the menu ...");


            BusinessLogicService businessLogicService = new BusinessLogicService();

            string pizzaName = Console.ReadLine();

            businessLogicService.menuService(pizzaName);
        }
    }

}

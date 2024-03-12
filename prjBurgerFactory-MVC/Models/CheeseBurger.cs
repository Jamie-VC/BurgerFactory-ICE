namespace prjBurgerFactory_MVC.Models
{
    public class CheeseBurger :IBurger
    {
        public string getBun()
        {
            return "Wheat";
        }

        public string getCondiments()
        {
            return "Cheese,Cheese,Cheese,Cheese Sauce";
        }

        public string getPatty()
        {
            return "Beef";
        }
    }
}

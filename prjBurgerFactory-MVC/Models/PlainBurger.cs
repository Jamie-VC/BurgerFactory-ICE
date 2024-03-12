namespace prjBurgerFactory_MVC.Models
{
    public class PlainBurger :IBurger
    {
        public string getBun()
        {
            return "Wheat";
        }

        public string getCondiments()
        {
            return "Tomato Sauce";
        }

        public string getPatty()
        {
            return "Beef";
        }
    }
}

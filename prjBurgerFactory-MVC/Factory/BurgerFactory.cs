using prjBurgerFactory_MVC.Models;

namespace prjBurgerFactory_MVC.Factory
{
    public class BurgerFactory
    {
        public IBurger returnInstance;
        public IBurger getBurger(String BurgerType)
        {
            if (BurgerType.ToLower().Equals("chicken"))
            {
                returnInstance = new ChickenBurger();
            }
            else if (BurgerType.ToLower().Equals("cheese"))
            {
                returnInstance = new CheeseBurger();
            }
            else
            {
                returnInstance = new PlainBurger();
            }
            return returnInstance;
        }
    }
}

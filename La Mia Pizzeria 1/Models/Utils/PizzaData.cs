using System.Reflection.Metadata.Ecma335;

namespace La_Mia_Pizzeria_1.Models.Utils
{


    public static class PizzaData
    {
        private static List<Pizza>? pizzas;

        public static List<Pizza> GetPizzas()
        {

            if (pizzas != null)
            {
                return pizzas;
            }

            pizzas = new List<Pizza>();

            Pizza pizza01 = new Pizza(0, "Margherita", "Salsa di pomodoro, mozzarella, basilico fresco", "" + "/100");
            pizzas.Add(pizza01);

            Pizza pizza02 = new Pizza(1, "Diavola", "Salsa di pomodoro, mozzarella, salame piccante", "https://www.lennesimoblogdicucina.com/wp-content/uploads/2020/06/pizza-margherita-con-fornetto-innerimageoptim-1050x1575.jpg" + "/100");
            pizzas.Add(pizza02);

            Pizza pizza03 = new Pizza(2, "Prosciutto e funghi", "Salsa di pomodoro, mozzarella, prosciutto cotto, funhi di stagione", "https://picsum.photos/id/1" + "/100");
            pizzas.Add(pizza03);

            Pizza pizza04 = new Pizza(3, "Marinara", "Salsa di pomodoro fresco, origano, olio extravergine d'oliva", "https://picsum.photos/id/1" + "/100");
            pizzas.Add(pizza04);

            Pizza pizza05 = new Pizza(4, "Straciatella e speck", "Salsa di pomodoro, straciatella di burrata, speck trentino", "https://picsum.photos/id/1" + "/100");
            pizzas.Add(pizza05);

            Pizza pizza06 = new Pizza(5, "Bufala", "Salsa di pomodoro, mozzarella di bufala campana, basilico fresco, olio extravergine d'oliva", "https://picsum.photos/id/1" + "/100");
            pizzas.Add(pizza06);






            return pizzas;
        }
        
    }
}


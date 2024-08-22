using Bookstore;

namespace Program
{
    public class Exercises
    {
        public static void Main()
        {
            //Products
            var book_1 = new Product("Percy Jackson and the Olympians - The Lighting Thief", 59.90f);
            var book_2 = new Product("Percy Jackson and the Olympians - The Sea of Monsters", 59.90f);
            var book_3 = new Product("Percy Jackson and the Olympians - The Titan's Curse", 59.90f);
            var book_4 = new Product("Percy Jackson and the Olympians - The Battle of the Labyrinth", 59.90f);
            var book_5 = new Product("Percy Jackson and the Olympians - The Last Olympian", 59.90f);
            var book_6 = new Product("White Fang", 39.90f);
            var book_7 = new Product("The Little Prince", 34.90f);
            var book_8 = new Product("The Man Who Hears Horses", 54.90f);

            //Clients
            var pedro = new Client("example@gmail.com", "Pedro da Fonseca Schwertner");

            //Cart
            var myCart = new Cart(pedro);

            myCart.AddProduct(book_1);
            myCart.AddProduct(book_3);
            myCart.AddProduct(book_4);
            myCart.AddProduct(book_6);
            myCart.AddProduct(book_7);

            //Show info
            Console.WriteLine($"Order #1785\n------------------------------\n");
            pedro.ShowInfo();
            Console.WriteLine("\n------------------------------\n");
            foreach (var item in myCart.Products)
            {
                Console.WriteLine($"Name: {item.Name} - Price: R$ {item.Price}");
            }
        }
    }
}
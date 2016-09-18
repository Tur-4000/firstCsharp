using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAdviser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа поможет подобрать вам фильм для вечернего просмотра");
            Console.WriteLine("Как вас зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name);

            Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть: комедия или драма?");
            String genre = Console.ReadLine();

            Console.WriteLine("В таком случае, рекомендую посмотреть вам следующие фильмы:");

            if (genre == "комедия")
            {                
                Console.WriteLine("* Иван Васильевич меняет профессию");
                Console.WriteLine("* Операция «Ы» и другие приключения Шурика");
                Console.WriteLine("* Назад в будущее");
                Console.WriteLine("* В джазе только девушки");
                Console.WriteLine("* Клерки");
                Console.WriteLine("* Клерки 2");
                Console.WriteLine("* Тусовщики из супермаркета");
                Console.WriteLine("* Джей и Молчаливый Боб наносят ответный удар");
                Console.WriteLine("* Догма");
                Console.WriteLine("* В погоне за Эми");
            }
            else
            {
                Console.WriteLine("* Зелёная миля");
                Console.WriteLine("* Побег из Шоушенка");
            }

            Console.ReadLine();
        }
    }
}

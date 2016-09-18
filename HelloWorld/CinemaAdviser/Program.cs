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

            if(genre == "комедия")
            {
                Console.WriteLine("В таком случае, рекомендую посмотреть вам следующие фильмы:");
                Console.WriteLine("* Ивын Васильевич меняет профессию");
                Console.WriteLine("* Операция «Ы» и другие приключения Шурика");
                Console.WriteLine("* Назад в будущее");
                Console.WriteLine("* В джазе только девушки");
            }

            Console.ReadLine();
        }
    }
}

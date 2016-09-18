using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAdviser {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Эта программа поможет подобрать вам фильм для вечернего просмотра");
            Console.WriteLine("Как вас зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name);

            Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть: комедия, драма, фантастика, эротика?");
            String genre = Console.ReadLine();

            Console.WriteLine("В таком случае, рекомендую посмотреть вам следующие фильмы:");

            if (genre == "комедия") {
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
            } else if (genre == "фантастика") {
                Console.WriteLine("* Люди икс");
                Console.WriteLine("* Стражи галактики");
                Console.WriteLine("* Люди в чёрном");
            } else if (genre == "эротика") {
                Console.WriteLine("Скоько вам лет?");
                int years = Int32.Parse(Console.ReadLine());
                if(years < 18) {
                    Console.WriteLine("К сожалению, этот жанр доступен только для пользователей 18+");
                    Console.WriteLine("Приходите через " + (18 - years) + " лет");
                } else {
                    Console.WriteLine("* Эммануэль");
                    Console.WriteLine("* Греческая смоковница");
                }
            } else {
                Console.WriteLine("* Зелёная миля");
                Console.WriteLine("* Побег из Шоушенка");
            }

            Console.ReadLine();
        }
    }
}

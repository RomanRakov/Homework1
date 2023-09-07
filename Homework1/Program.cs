using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1a");
            Console.WriteLine("Необходимо вывести 'Мир Труд Май' ");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine();


            Console.WriteLine("Задание 1b");
            Console.WriteLine("Необходимо вывести 'Мир Труд Май',причем так, чтобы каждое слово было с новой строки и с отступом слева");
            Console.WriteLine("Мир");
            Console.WriteLine("{0, 6}", "Труд"); // выводит слово в консоль с отступом 
            Console.WriteLine("{0, 9}", "Май");  // выводит слово в консоль с отступом 
            Console.WriteLine();


            Console.WriteLine("Задание 2");
            Console.WriteLine("Необходимо поменять 2 числа местами, причем учесть, что пользователь может ввести число через точку или запятую, или ввсети букву");
            try
            {
                Console.Write("Введите первую переменную: ");
                string number1 = Console.ReadLine();
                Console.Write("Введите вторую переменную: ");
                string number2 = Console.ReadLine();
                number1 = number1.Replace(".", ","); //меняет точку на запятую
                number2 = number2.Replace(".", ","); //меняет точку на запятую
                double number3 = Convert.ToDouble(number1);
                double number4 = Convert.ToDouble(number2);
                (number3, number4) = (number4, number3); // меняет переменные местами
                Console.WriteLine("Первая переменная: {0}", number3);
                Console.WriteLine("Вторая переменная: {0}", number4);

            }
            catch
            {
                Console.WriteLine("Вы неправильно ввели данные");
            }
            Console.WriteLine("Задание 3");
            Console.WriteLine("Необходимо получить длину окружности и площадь круга");
            Console.WriteLine("Введите радиус окружности:");
            double rad = Convert.ToDouble(Console.ReadLine());
            double length = 2 * Math.PI * rad; // находит длину окружности
            Console.WriteLine("Длина окружности = {0}", length);
            double RAD = Math.Pow(rad, 2); // находит квадрат радиуса
            double space = RAD * Math.PI; // находит плщщадь круга
            Console.WriteLine("Площадь круга = {0}", space);
            Console.WriteLine();


            Console.WriteLine("Задание 4");
            Console.WriteLine("Необходимо посчитать косинус угла");
            Console.WriteLine("Введите угол в радианах:");
            double x = Convert.ToDouble(Console.ReadLine());
            double cos = Math.Cos(x); // находит косинус угла
            Console.WriteLine("Косинус числа x = {0}", cos);
            Console.WriteLine();


            Console.WriteLine("Задание 5");
            Console.WriteLine("Необходимо найти корни квадратного уравнения");
            Console.WriteLine("Введите первый коэффицент:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второй коэффинцент:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третий коэффицент:");
            double c = Convert.ToDouble(Console.ReadLine());
            double B = Math.Pow(b, 2);
            double D = B - 4 * a * c; // находит дискриминант
            Console.WriteLine("Дискриминант = {0}", D);
            if (D == 0) // если дискриминант > 0
            {
                double X1 = -b / 2;
                Console.WriteLine("x1 = {0}", X1);
            }
            else if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D) / 2 * a);
                double x2 = (-b + Math.Sqrt(D) / 2 * a);
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }
            else // если дискриминант < 0
            {
                Console.WriteLine("Уравнение не имеет корней");
            }
            Console.WriteLine();


            Console.WriteLine("Задание 6a");
            Console.WriteLine("Необходимо переменной b присвоить значение c, a присвоить значение b, c присвоить значение a");
            Console.WriteLine("Введите коэффициент a:");
            double ratio1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b:");
            double ratio2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c:");
            double ratio3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Новое значение a = {0}", ratio2);
            Console.WriteLine("Новое значение b = {0}", ratio3);
            Console.WriteLine("Новое значение с = {0}", ratio1);
            Console.WriteLine();


            Console.WriteLine("Задание 6b");
            Console.WriteLine("Необходимо переменной b присвоить значение a, c присвоить значение b, a присвоить значение c");
            Console.WriteLine("Введите коэффициент a:");
            double ratio4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b:");
            double ratio5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c:");
            double ratio6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Новое значение a = {0}", ratio5);
            Console.WriteLine("Новое значение b = {0}", ratio4);
            Console.WriteLine("Новое значение с = {0}", ratio6);
            Console.WriteLine();


            Console.WriteLine("Задание 7");
            Console.WriteLine("Необходимо вывести на экран 4 случайных числа");
            Random rnd = new Random(); // объект для генерации случайных чисел
            int numb1 = rnd.Next(); // генерирует случайное число
            Console.WriteLine(numb1);
            int numb2 = rnd.Next(); // генерирует случайное число
            Console.WriteLine(numb2);
            int numb3 = rnd.Next(); // генерирует случайное число
            Console.WriteLine(numb3);
            int numb4 = rnd.Next(); // генерирует случайное число
            Console.WriteLine(numb4);
            Console.WriteLine();


            Console.WriteLine("Задание 8");
            Console.WriteLine("Необходимо переставить последнюю цифру трехзначного числа в начало");
            Console.WriteLine("Введите трехзначное число: ");
            string number = Console.ReadLine();
            Console.WriteLine("Ответ: {0}{1}{2}", number[2], number[0], number[1]); // ставит 3 символ на первое место
            Console.WriteLine();


            Console.WriteLine("Задание 9");
            Console.WriteLine("Необходимо найти стоимость покупки");
            Console.WriteLine("Введите стоимость 1кг конфет = ");
            double cost1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1кг печенья = ");
            double cost2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость 1кг яблок = ");
            double cost3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес конфет(в кг) = ");
            double quan1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес печенья(в кг) = ");
            double quan2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес яблок(в кг) = ");
            double quan3 = Convert.ToDouble(Console.ReadLine());
            double sum = cost1 * quan1 + cost2 * quan2 + cost3 * quan3;
            Console.WriteLine("Стоимость всей покупки = {0} ", sum);
            Console.ReadKey();


        }

    }
}


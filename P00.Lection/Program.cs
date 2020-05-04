namespace P00.Lection
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<IAnimal>();
            list.Add(new Cat("Pesho"));
            list.Add(new Bunny());

            foreach (var animal in list)
            {
                Console.Write($"{animal.Name} ");
                animal.Move(5,5);
            }

            //IEnumerable

            var numbers = new Numbers(new[] {1, 2, 3 });
            int sum = 0;
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}

namespace P00.Lection
{
    using System;
    public class Cat : IAnimal
    {
        public Cat(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public void Move(int x, int y)
        {
            Console.WriteLine("Cat move");
        }
    }
}

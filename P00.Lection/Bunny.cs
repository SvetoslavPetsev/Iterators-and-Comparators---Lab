namespace P00.Lection
{
    using System;
    public class Bunny : IAnimal
    {
        public string Name { get => "Bugs"; }

        public void Move(int x, int y)
        {
            Console.WriteLine("Bunny move");
        }
    }
}

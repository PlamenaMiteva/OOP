namespace Animals.Models
{
    using System;

    public class Kitten:Animal
    {
        public Kitten(string name, int age) : base(name, age)
        {
            this.Gender = Gender.Female;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miauu");
        }
    }
}

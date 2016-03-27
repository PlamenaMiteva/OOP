namespace Animals.Models
{
    using System;

    public class Tomcat : Animal
    {
        public Tomcat(string name, int age)
            : base(name, age)
        {
            this.Gender = Gender.Male;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miauu");
        }
    }
}

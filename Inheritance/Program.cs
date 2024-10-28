namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.eat();
            dog.sleep();
            dog.makeSound();

            Person teacher = new Teacher();//Person türünde bir teacher nesnesi oluşturduk. Soyutlama sayesinde Person sınıfından türetilen Teacher sınıfını kullanabiliyoruz.
            teacher.Name = "John";
            teacher.Surname = "Doe";

        }
    }
}

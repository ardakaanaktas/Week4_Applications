namespace InheritancePractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();//creating an object of Teacher class
            teacher.Name = "John";//setting the value of Name property
            teacher.Surname = "Doe";//setting the value of Surname property
            teacher.salary = 5000;//setting the value of salary property
            teacher.getInfo();//calling the getInfo method of Teacher class

            Console.WriteLine("----------------------------------------");

            Student student = new Student();//creating an object of Student class
            student.Name = "Jane";//setting the value of Name property
            student.Surname = "Doe";//setting the value of Surname property
            student.StudentNumber = "123456";//setting the value of StudentNumber property
            student.getInfo();//calling the getInfo method of Student class
        }
    }
}

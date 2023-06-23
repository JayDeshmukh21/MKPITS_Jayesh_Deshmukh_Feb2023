namespace mcv2.Models
{
    public class Employee1
    {
        public string name;
        public int age;
        //constructor
        public Employee1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
    }
}


namespace BasicApp
{
    public abstract class Person
    {
        public string name { get; private set; }
        public string surname { get; private set; }
        public string sex { get; private set; }
        public int age { get; private set; }
        public Person()
        {
            this.name = "no name";
            this.surname = "no surname";
            this.age = 0;
            this.sex = "M";
        }

        public Person(string name, string surname, int age, string sex)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.sex = sex;
        }
    }
}

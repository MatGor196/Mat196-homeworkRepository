namespace BasicApp
{
    class Employee
    {
        public string name { get; private set; }
        public string surname { get; private set; }
        public int age { get; private set; }

        private List<int> scores = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public void AddScore(int score)
        {
            (this.scores).Add(score);
        }

        public int SumScore()
        {
            return (this.scores).Sum();
        }

        public string ReturnFullName()
        { return this.name + " " + this.surname; }
    }
}

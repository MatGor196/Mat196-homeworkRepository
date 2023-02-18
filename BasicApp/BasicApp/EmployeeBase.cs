namespace BasicApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public string name { get; private set; }
        public string surname { get; private set; }
        public string sex { get; private set; }
        public int age { get; private set; }

        public delegate void ScoreAddedDelegateType(object sender, EventArgs args);
        public abstract event ScoreAddedDelegateType ScoreAdded;

        public EmployeeBase()
        {
            this.name = "no name";
            this.surname = "no surname";
            this.age = 0;
            this.sex = "M";
        }

        public EmployeeBase(string name, string surname, int age, string sex)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.sex = sex;
        }

        public abstract void AddScore(int score);
        public abstract void AddScore(float score);
        public abstract void AddScore(string score);
        public abstract int SumScore();
        public abstract Statistics GetStatistics();
    }
}

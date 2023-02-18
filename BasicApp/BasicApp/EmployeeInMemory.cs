namespace BasicApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<int> scores = new List<int>();

        public override event ScoreAddedDelegateType ScoreAdded;

        public EmployeeInMemory() : base()
        { }

        public EmployeeInMemory(string name, string surname, int age, string sex) :
            base(name, surname, age, sex)
        { }

        public override void AddScore(int score)
        {
            if (0 <= score && score <= 100)
            {
                (this.scores).Add(score);

                if (ScoreAdded != null)
                {
                    ScoreAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Podano ocenę z poza zakresu");
            }
        }

        public override void AddScore(float score)
        {
            int scoreInInt = (int)Math.Round(score);
            this.AddScore(scoreInInt);
        }

        public override void AddScore(string score)
        {
            switch (score)
            {
                case "A":
                case "a":
                    this.AddScore(90);
                    break;
                case "B":
                case "b":
                    this.AddScore(70);
                    break;
                case "C":
                case "c":
                    this.AddScore(50);
                    break;
                case "D":
                case "d":
                    this.AddScore(30);
                    break;
                case "E":
                case "e":
                    this.AddScore(10);
                    break;
                default:
                    if (float.TryParse(score, out float resultAsFloat))
                    {
                        this.AddScore(resultAsFloat);
                    }
                    else
                    {
                        throw new Exception("Podano niewłaściwą ocenę (w formie string)");
                    }
                    break;
            }
        }

        public override int SumScore()
        {
            return (this.scores).Sum();
        }

        public override Statistics GetStatistics()
        {
            Statistics stat = new Statistics();

            foreach (var score in this.scores)
            {
                stat.AddScore(score);
            }

            return stat;
        }
    }
}
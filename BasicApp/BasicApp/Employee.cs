namespace BasicApp
{
    public class Employee : Person
    {
        private List<int> scores = new List<int>();

        public Employee() : base()
        {}

        public Employee(string name, string surname, int age, string sex):
            base(name, surname, age, sex)
        {}

        public void AddScore(int score)
        {
            if (0 <= score && score <= 100)
            {
                (this.scores).Add(score);
            }
            else
            {
                throw new Exception("Podano ocenę z poza zakresu");
            }
        }

        public void AddScore(string score)
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

        public void AddScore(float score)
        {
            int scoreInInt = (int)Math.Round(score);
            this.AddScore(scoreInInt);
        }

        public int SumScore()
        {
            return (this.scores).Sum();
        }

        public Statistics GetStatistics()
        {
            Statistics stat = new Statistics();

            foreach (var score in this.scores)
            {
                stat.MinScore = Math.Min(stat.MinScore, score);
                stat.MaxScore = Math.Max(stat.MaxScore, score);
                stat.AverageScore += score;
            }

            if ((this.scores).Count() != 0)
            {
                stat.AverageScore /= (this.scores).Count();

                switch(stat.AverageScore)
                {
                    case var average when average >= 80:
                        stat.AverageScoreLetter = 'A';
                        break;
                    case var average when average >= 60:
                        stat.AverageScoreLetter = 'B';
                        break;
                    case var average when average >= 40:
                        stat.AverageScoreLetter = 'C';
                        break;
                    case var average when average >= 20:
                        stat.AverageScoreLetter = 'D';
                        break;
                    default:
                        stat.AverageScoreLetter = 'E';
                        break;
                }
            }
            else
            {
                stat.MinScore = 0;
                stat.MaxScore = 0;
            }

            return stat;
        }
    }
}
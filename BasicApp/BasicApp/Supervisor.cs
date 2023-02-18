
namespace BasicApp
{
    public class Supervisor : EmployeeBase
    {
        private List<int> scores = new List<int>();

        public override event ScoreAddedDelegateType ScoreAdded;

        public Supervisor(): base()
        { }

        public Supervisor(string name, string surname, int age, string sex):
            base(name, surname, age, sex)
        { }

        public override void AddScore(int score)
        {
            if (0 <= score && score <= 100)
            {
                (this.scores).Add(score);

                if(ScoreAdded != null)
                {
                    ScoreAdded(this, EventArgs.Empty);
                }
            }
            else
            {
                throw new Exception("Podano ocenę z poza zakresu");
            }
        }

        public override void AddScore(string score)
        {
            switch (score)
            {
                case "s 6":
                    this.AddScore(100);
                    break;
                case "s 6-":
                case "s -6":
                    this.AddScore(95);
                    break;
                case "s 5":
                    this.AddScore(80);
                    break;
                case "s 5+":
                case "s +5":
                    this.AddScore(85);
                    break;
                case "s 5-":
                case "s -5":
                    this.AddScore(75);
                    break;
                case "s 4":
                    this.AddScore(60);
                    break;
                case "s 4+":
                case "s +4":
                    this.AddScore(65);
                    break;
                case "s 4-":
                case "s -4":
                    this.AddScore(55);
                    break;
                case "s 3":
                    this.AddScore(40);
                    break;
                case "s 3+":
                case "s +3":
                    this.AddScore(45);
                    break;
                case "s 3-":
                case "s -3":
                    this.AddScore(35);
                    break;
                case "s 2":
                    this.AddScore(20);
                    break;
                case "s 2+":
                case "s +2":
                    this.AddScore(25);
                    break;
                case "s 2-":
                case "s -2":
                    this.AddScore(15);
                    break;
                case "s 1":
                    this.AddScore(0);
                    break;
                case "s 1+":
                case "s +1":
                    this.AddScore(5);
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

        public override void AddScore(float score)
        {
            int scoreInInt = (int)Math.Round(score);
            this.AddScore(scoreInInt);
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

            //foreach (var score in this.scores)
            //{
            //    stat.MinScore = Math.Min(stat.MinScore, score);
            //    stat.MaxScore = Math.Max(stat.MaxScore, score);
            //    stat.AverageScore += score;
            //}

            //if ((this.scores).Count() != 0)
            //{
            //    stat.AverageScore /= (this.scores).Count();

            //    switch (stat.AverageScore)
            //    {
            //        case var average when average >= 80:
            //            stat.AverageScoreLetter = 'A';
            //            break;
            //        case var average when average >= 60:
            //            stat.AverageScoreLetter = 'B';
            //            break;
            //        case var average when average >= 40:
            //            stat.AverageScoreLetter = 'C';
            //            break;
            //        case var average when average >= 20:
            //            stat.AverageScoreLetter = 'D';
            //            break;
            //        default:
            //            stat.AverageScoreLetter = 'E';
            //            break;
            //    }
            //}
            //else
            //{
            //    stat.MinScore = 0;
            //    stat.MaxScore = 0;
            //}

            return stat;
        }
    }
}

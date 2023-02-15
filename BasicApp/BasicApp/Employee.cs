namespace BasicApp
{
    public class Employee
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
            if(1 <= score && score <= 10)
            {
                (this.scores).Add(score);
            }
            else
            {
                Console.WriteLine("Score is outside the range");
            }
        }

        public void AddScore(string score)
        {
            if(int.TryParse(score, out int resultInInt))
            {
                this.AddScore(resultInInt);
            }
            else
            {
                Console.WriteLine("Cannot convert string to int");
            }
        }

        public void AddScore(float score)
        {
            int scoreInInt = (int)Math.Round(score);
            this.AddScore(scoreInInt);
        }

        public void AddScore(double score)
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

            foreach(var score in this.scores)
            {
                stat.MinScore = Math.Min(stat.MinScore, score);
                stat.MaxScore = Math.Max(stat.MaxScore, score);
                stat.AverageScore += score;
            }

            if((this.scores).Count() != 0)
            {
                stat.AverageScore /= (this.scores).Count();
            }
            else
            {
                stat.AverageScore = float.MinValue; // means error
            }

            return stat;
        }

        public Statistics GetStatisticsWithForEach()
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
            }
            else
            {
                stat.AverageScore = float.MinValue; // means error
            }

            return stat;
        }

        public Statistics GetStatisticsWithFor()
        {
            Statistics stat = new Statistics();

            
            for(int index = 0; index < (this.scores).Count(); index++)
            {
                stat.MinScore = Math.Min(stat.MinScore, this.scores[index]);
                stat.MaxScore = Math.Max(stat.MaxScore, this.scores[index]);
                stat.AverageScore += this.scores[index];
            }

            if ((this.scores).Count() != 0)
            {
                stat.AverageScore /= (this.scores).Count();
            }
            else
            {
                stat.AverageScore = float.MinValue; // means error
            }

            return stat;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            Statistics stat = new Statistics();

            int index = 0;
            do
            {
                stat.MinScore = Math.Min(stat.MinScore, this.scores[index]);
                stat.MaxScore = Math.Max(stat.MaxScore, this.scores[index]);
                stat.AverageScore += this.scores[index];
                index++;
            } while (index < (this.scores).Count());

            if ((this.scores).Count() != 0)
            {
                stat.AverageScore /= (this.scores).Count();
            }
            else
            {
                stat.AverageScore = float.MinValue; // means error
            }

            return stat;
        }

        public Statistics GetStatisticsWithWhile()
        {
            Statistics stat = new Statistics();

            int index = 0;
            while(index < (this.scores).Count())
            {
                stat.MinScore = Math.Min(stat.MinScore, this.scores[index]);
                stat.MaxScore = Math.Max(stat.MaxScore, this.scores[index]);
                stat.AverageScore += this.scores[index];
                index++;
            }

            if ((this.scores).Count() != 0)
            {
                stat.AverageScore /= (this.scores).Count();
            }
            else
            {
                stat.AverageScore = float.MinValue; // means error
            }

            return stat;
        }
    }
}
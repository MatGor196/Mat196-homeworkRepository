namespace BasicApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileWithScoresName = "scores.txt";

        public override event ScoreAddedDelegateType ScoreAdded;

        public EmployeeInFile() : base()
        { }

        public EmployeeInFile(string name, string surname, int age, string sex) :
            base(name, surname, age, sex)
        { }

        public override void AddScore(int score)
        {
            if (0 <= score && score <= 100)
            {
                using(var writer = File.AppendText(fileWithScoresName))
                {
                    writer.WriteLine(score);
                }

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

        private List<int> ReadScoresFromFile()
        {
            var scoresFromFile = new List<int>();

            if (File.Exists(fileWithScoresName))
            {
                using(var reader = File.OpenText(fileWithScoresName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = int.Parse(line);
                        scoresFromFile.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }

            return scoresFromFile;
        }

        public override int SumScore()
        {
            var scoresFromFile = new List<int>();
            scoresFromFile = ReadScoresFromFile();

            return scoresFromFile.Sum();
        }

        public override Statistics GetStatistics()
        {
            Statistics stat = new Statistics();

            var scoresFromFile = new List<int>();
            scoresFromFile = ReadScoresFromFile();

            foreach (var score in scoresFromFile)
            {
                stat.AddScore(score);
            }

            return stat;
        }
    }
}

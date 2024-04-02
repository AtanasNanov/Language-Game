using System;

namespace LanguageGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] correctWords = new string[]
            {
                "abundance",
                "accommodate",
                "acknowledge",
                "misspelling",
                "experimental",
                "trouble",
                "conscious",
                "weird",
                "management",
                "agreement",
                "February",
                "independent",
                "surprise",
                "necessary",
                "accommodate",
                "receive",
                "appear",
                "develop",
                "believe",
                "necessitate",
                "afraid",
                "jealous",
                "until",
                "recommend",
                "their",
                "physical",
                "prefer",
                "yearly",
                "possess",
                "aggressive",
                "privilege",
                "absence",
                "jealousy",
                "acquaintance",
                "business",
                "unfortunately",
                "accommodate",
                "incorrect",
                "noticeable",
                "consistent",
                "accidentally",
                "disappear",
                "acknowledgment",
                "algorithm",
                "software",
                "hardware",
                "artificial intelligence",
                "robotics",
                "automation",
                "virtual reality",
                "augmented reality",
                "blockchain",
                "cryptocurrency",
                "cybersecurity",
                "data mining",
                "cloud computing",
                "internet of things (iot)",
                "machine learning",
                "nanotechnology",
                "quantum computing",
                "biotechnology",
                "3d printing",
                "wireless technology",

            };
            string[] incorrectWords = new string[]
            {
                "abudance",
                "acomodate",
                "acknolwedge",
                "mispeling",
                "experimantal",
                "trubble",
                "concious",
                "wierd",
                "managment",
                "aggreement",
                "febuary",
                "independant",
                "suprize",
                "neccessary",
                "acommodate",
                "recieve",
                "apear",
                "develope",
                "belive",
                "neccesitate",
                "afreid",
                "jelous",
                "untill",
                "recomend",
                "thier",
                "phisical",
                "prefferr",
                "yerly",
                "posses",
                "aggresive",
                "privilege",
                "absence",
                "jelousy",
                "acquitance",
                "buisness",
                "unfortunatly",
                "accomodate",
                "inncorrect",
                "noticable",
                "consistant",
                "accidentally",
                "disapear",
                "acknowledgement",
                "algoritm",
                "softwear",
                "hardwear",
                "artificl intelligence",
                "robotix",
                "automashun",
                "virtuul reality",
                "augmentid reality",
                "blockchane",
                "cryptocurency",
                "cybersecuritee",
                "data mineing",
                "clowd computing",
                "internet of thinks (iot)",
                "masheen learning",
                "nanotecnology",
                "quantum computin",
                "byotechnology",
                "3d printng",
                "wireles technolgy",
            };

            Random random = new Random();

            Console.WriteLine("Welcome to the Language Game!");

            int score = 0;
            int totalRounds = 10;

            for (int i = 0; i < totalRounds; i++)
            {
                Console.Clear();

                int index = random.Next(correctWords.Length);
                string correctWord = correctWords[index];
                string misspelledWord = incorrectWords[index];

                int correctPosition = random.Next(2);

                Console.WriteLine($"\nRound {i + 1}: Which word is spelled correctly?");
                Console.WriteLine($"1. {(correctPosition == 0 ? correctWord : misspelledWord)}");
                Console.WriteLine($"2. {(correctPosition == 1 ? correctWord : misspelledWord)}");

                Console.Write("Enter your choice (1 or 2): ");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
                {
                    Console.Write("Invalid input. Please enter 1 or 2: ");
                }

                if (choice == correctPosition + 1)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct spelling is: {correctWord}");
                }

                System.Threading.Thread.Sleep(2000);
            }

            Console.WriteLine($"\nGame Over! Your final score is: {score}/{totalRounds}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictiveText
{
    class Program
    {
        static void Main(string[] args)
        {
            var tw = TrainWords("Hello my name is chandler and I is very very repetitive is I wish is I could stop");

            //for (int index = 0; index < 11; index++)
            //{
            //   Console.WriteLine($"Given: {tw[index].Word}\nNext Word: {tw[index].NextWord}\n\n");
            //}

            Console.WriteLine(DefaultWords(tw, "my", 5));
        }

        static string DefaultWords(List<TrainedWord> words, string firstWord, int count)
        {
            string str = "";

            for (int i = 0; i < count; i++)
            {
                str += firstWord + " ";

                firstWord = words.FirstOrDefault(x => x.Word == firstWord).NextWord;
            }

            return str;
        }

        static List<TrainedWord> TrainWords(string text)
        {
            // Uniform list of words in sentence
            var wordList = text.ToLower().Split(' ').ToList();

            // List of distinct trained words
            var trainedWords = new List<TrainedWord>();
            foreach (var str in wordList.Distinct())
                trainedWords.Add(new TrainedWord(str));

            // Train words
            for (int i = 0; i < wordList.Count - 1; i++)
            {
                var currentTrainedWord = trainedWords.First(x => x.Word == wordList[i]);
                var nextWord = wordList[i + 1];

                if (currentTrainedWord.Word != nextWord)
                {
                    if (currentTrainedWord.Commonality.ContainsKey(nextWord))
                        currentTrainedWord.Commonality[nextWord] += 1;
                    else
                        currentTrainedWord.Commonality.Add(nextWord, 1);
                }
            }

            return trainedWords;
        }
    }

    class TrainedWord
    {
        public string Word { get; set; }
        public Dictionary<string, int> Commonality { get; set; }
        public string NextWord => Commonality.Aggregate((x, r) => x.Value > r.Value ? x : r).Key;

        public TrainedWord(string word)
        {
            this.Word = word;
            this.Commonality = new Dictionary<string, int>();
        }
    }
}

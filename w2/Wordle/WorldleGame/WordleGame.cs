using System.Text;
namespace Wordle {

public class WordleGame {
static string[] wordBank = {"liam", "luc", "ethan"};
string path;
string RandomWord;
static int wordBankSize = wordBank.Length - 1;
int AttemptLimits = 4;
int Attempts = 0;

            public WordleGame() {
                var rand = new Random();
                int RandomIndex = rand.Next(0, wordBankSize);
                string RandomWord = wordBank[RandomIndex];
                
                
                StringBuilder sb = new StringBuilder("");
                int counter = 0;
                while (counter < RandomWord.Length)  {
                 sb.Append("_");
                    counter++;
                
                }
                Console.WriteLine("The word you're looking for is: "+sb);
                Console.WriteLine(RandomWord);
                Console.WriteLine("Please enter a letter");
                string userInput = Console.ReadLine();
                //nested loop
                for (int i = 0; i < userInput.Length; i++) {
                        char s = userInput[i];
                        for (int j = 0; j < RandomWord.Length; j++) {
                            char a = RandomWord[j];
                            if (a.Equals(s)) {
                                Console.WriteLine("This letter is there");

                                //set an answer to true
                            }
                            else {
                                //keeps it false
                                Console.WriteLine("This letter isn't there");
                            }
                        }
                }
            }
                } 
     }
namespace Outguess {
    internal class Program {
        static void Main(string[] args) {


            OutguessAddendum();

        }//END MAIN
        static void Outguess() {
            bool doesContinue = true;
            int playerNum = 0; 
                int cpuNum = 0;
                char cont = ' ';

            while (doesContinue) {
                int guesses = 7;
                int strikes = 1;
                Random rng = new Random();
                cpuNum = rng.Next(1, 101);

                Fancify("WELCOME TO EVIL OUTGUESS");
                Console.WriteLine("\n\nInput a number between 1 and 100 and guess the evil computer's number. You only have 7 guesses so make 'em count!!\nDon't pull anything funny or you'll lose guesses!");
                while (guesses > 0) {
                    playerNum = PromptInt("\n");
                    if ((playerNum < 0 || playerNum > 100) && strikes <= 0) {
                        guesses -= 2;
                        Console.WriteLine($"Why did you do this? You've lost your next guess. {guesses} left.");
                    } else if ((playerNum > 100 || playerNum < 1) && strikes > 0) {
                        strikes--;
                        Console.WriteLine($"Please remember to input a positive number between 1 and 100.\nNext time it'll count and you'll lose a guess ontop of that!");
                    } else if (playerNum == cpuNum) {
                        guesses = 0;
                    } else if (playerNum > cpuNum){
                        guesses--;
                        Console.WriteLine($"TOO HIGH! {guesses} guesses left!!");
                    } else if(playerNum < cpuNum) {
                        guesses--;
                        Console.WriteLine($"TOO LOW! {guesses} guesses left!");
                    }//END IF ELSE GUESSES
                    
                }//END WHILE GUESSES
            if (playerNum == cpuNum) {
                Console.WriteLine("\n\nCONGRATULATIONS!! You've beaten my computer mind...");
                    bool isValid = false;
                    while (isValid == false) {
                        Console.WriteLine("Would you like to play again?(y/n) ");
                        cont = Console.ReadKey(true).KeyChar;
                        if (cont == 'n' || cont == 'N') {
                            Console.WriteLine("\nWhatever I didn't want to anyway pshh");
                                doesContinue = false;
                                isValid = true;
                        } else if (cont == 'y' || cont == 'Y') {
                                doesContinue = true;
                                isValid = true;
                                Console.Clear();
                        } else {
                                Console.WriteLine("\nC'mon its 'y' or 'n'. You know this. Try again.");
                                isValid = false;
                                
                        }//END IF ELSE CONT

                    }//END ISVALID LOOP
            } else {
                    Console.WriteLine("\n\nYou lost. Sad :(");
                    Thread.Sleep(2000);
                    Console.WriteLine($"NOT! My number was {cpuNum}!! BAHAHAHAH!!!");
                    bool isValid = false;
                    while (isValid == false) {
                    Console.WriteLine("\nYou wanna play again?(y/n) ");
                    cont = Console.ReadKey(true).KeyChar;
                        if (cont == 'n' || cont == 'N') {
                            Console.WriteLine("\nWhatever, I didn't want to anyway pshh");
                            isValid = true;
                            doesContinue = false;
                        } else if (cont == 'y' || cont == 'Y') {
                            doesContinue = true;
                            isValid = true;
                            Console.Clear();
                        } else {
                            Console.WriteLine("\nC'mon its 'y' or 'n'. You know this. Try again.");
                            isValid = false;
                        }//END IF ELSE CONT
                    }//END ISVALID LOOP
            }//END IF ELSE WIN LOSE

            }//END CONT LOOP
        }//END OUTGUESS
        static void OutguessAddendum() {
            bool doesContinue = true;
            bool hasBust = false;
            int playerNum = 0;
            int cpuNum = 0;
            int[] wagerMultiplier = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
            double wins = 0;
            double rounds = 0;
            double playerBet = 0;
            double playerCash = 0;
            char cont = ' ';

                Fancify("WELCOME TO SINISTER OUTGUESS");
                Console.WriteLine("\n\nThe Evil Computer will think of a number between 1 and 100.\nIt is your goal to guess the right number before your guesses run out!");
                Console.WriteLine("\nThis time, you will choose the amount of guesses between 1 and 10.");
            doesContinue = false;
            while (doesContinue == false) {
                playerCash = PromptDouble("\nPlease input the amount of cash you're bringing to the outguess table: $");
                if (playerCash < 1){
                    Console.WriteLine("You have to come in with some money.");
                } else {
                    doesContinue=true;
                }//END CASH IF
            }//END CASH VALIDATION

            while (doesContinue && hasBust != true) {
                int guesses = 0;
                int strikes = 1;
                int guessWinnings = 0;
                bool isCheating = true;
                bool betOver = false;
                Random rng = new Random();
                cpuNum = rng.Next(1, 101);

                while (isCheating == true) {
                    guesses = PromptInt("\nGuesses: ");
                        if (guesses > 10 || guesses < 1) {
                            Console.WriteLine("NO CHEATING");
                        } else {
                            isCheating = false;
                            guessWinnings = wagerMultiplier[guesses-1];

                        }//END IF ELSE
                }//END GUESS VALID LOOP

                while (betOver == false) {
                    playerBet = PromptDouble("\nBet: $");
                    if (playerBet > playerCash) {
                        Console.WriteLine($"Your bet cannot be higher than your total cash, ${playerCash}.");
                    } else if (playerBet < 1){
                        Console.WriteLine("Your bet has to be a positive number.");
                    }else {
                        betOver = true;
                    }//END IF ELSE
                }//END BET VALID LOOP
                Console.WriteLine("\nNow let the guessing begin.\n");
                while (guesses > 0) {
                    playerNum = PromptInt("\n");
                    if ((playerNum > 100 || playerNum < 0) && strikes <= 0) {
                        guesses -= 2;
                        Console.WriteLine($"Why did you do this? You've lost your next guess. {guesses} left.");
                    } else if ((playerNum > 100 || playerNum < 1) && strikes > 0) {
                        strikes--;
                        Console.WriteLine($"Please remember to input a positive number between 1 and 100.\nNext time it'll count and you'll lose a guess ontop of that!");
                    } else if (playerNum == cpuNum) {
                        guesses = 0;
                    } else if (playerNum > cpuNum) {
                        guesses--;
                        Console.WriteLine($"TOO HIGH! {guesses} guesses left!!");
                    } else if (playerNum < cpuNum) {
                        guesses--;
                        Console.WriteLine($"TOO LOW! {guesses} guesses left!");
                    }//END IF ELSE GUESSES

                }//END WHILE GUESSES
                if (playerNum == cpuNum) {
                    Console.WriteLine("\n\nCONGRATULATIONS!! You've beaten my computer mind...");
                    wins++;
                    rounds++;
                    playerCash += playerBet * guessWinnings;
                    Console.WriteLine($"\nYou've won ${playerBet * guessWinnings}!!\n\nTotal Cash: ${playerCash}");
                    bool isValid = false;
                    while (isValid == false) {
                        Console.WriteLine("Would you like to play again?(y/n) ");
                        cont = Console.ReadKey(true).KeyChar;
                        if (cont == 'n' || cont == 'N') {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\n\nGOOD ENDING: You left the evil casino with ${playerCash} and bought a nice sandwich with your winnings.\nWin Percentage: {(wins / rounds) * 100}%");
                            Console.ResetColor();
                            doesContinue = false;
                            isValid = true;
                        } else if (cont == 'y' || cont == 'Y') {
                            doesContinue = true;
                            isValid = true;
                            Console.Clear();
                        } else {
                            Console.WriteLine("\nC'mon its 'y' or 'n'. Try again.");
                            isValid = false;

                        }//END IF ELSE CONT

                    }//END ISVALID LOOP
                } else {
                    Console.WriteLine("\n\nYou lost. Sad :(");
                    Thread.Sleep(2000);
                    Console.WriteLine($"NOT! My number was {cpuNum}!! BAHAHAHAH!!!");
                    rounds++;
                    playerCash -= playerBet;
                    Console.WriteLine($"You've lost ${playerBet}.\nTotal Cash: ${playerCash}");
                    if (playerCash == 0) {
                        hasBust = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"BAD ENDING: You've lost everything. Everyone hates you. Goodbye.\nWin Percentage: {(wins / rounds) * 100}%");
                        Console.ResetColor();
                    } else { 
                        bool isValid = false;
                        while (isValid == false) {
                            Console.WriteLine("\nYou wanna play again?(y/n) ");
                            cont = Console.ReadKey(true).KeyChar;
                            if (cont == 'n' || cont == 'N') {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"GOOD ENDING: You left the evil casino with ${playerCash} and bought a nice sandwich with your winnings.\nWin Percentage: {(wins / rounds) * 100}%");
                                Console.ResetColor();
                                isValid = true;
                                doesContinue = false;
                            } else if (cont == 'y' || cont == 'Y') {
                                doesContinue = true;
                                isValid = true;
                                Console.Clear();
                            } else {
                                Console.WriteLine("\nC'mon its 'y' or 'n'. Try again.");
                                isValid = false;
                            }//END IF ELSE CONT
                        }//END ISVALID LOOP
                    }//END IF BUST
                }//END IF ELSE WIN LOSE
            }//END CONT LOOP
        }//END OUTGUESS PT 2
        #region HELPER FUNCTIONS
        static void Fancify(string text) {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t\t**##=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=##**");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\t\t\t\t        --->>\\{text}/<<---");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t\t**##=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=##**");

            Console.ResetColor();

        }//END FANCIFY
        static string Prompt(string request) {
            //Variables
            string userInput = "";

            //Request Information From User
            Console.Write(request);

            //Receive Response
            userInput = Console.ReadLine();

            return userInput;

        }//END PROMPT HELPER
        static int PromptInt(string request) {

            int userInput = 0;
            bool isValid = false;

            Console.Write(request);
            isValid = int.TryParse(Console.ReadLine(), out userInput);
            
            while (isValid == false) {

                Console.WriteLine("ERROR: NO REAL NUMBER");
                Console.Write(request);
                isValid = int.TryParse(Console.ReadLine(), out userInput);
            }//END WHILE

            return userInput;

        }//END PROMPT TRY INT
        static double PromptDouble(string request) {

            double userInput = 0;
            bool isValid = false;

            Console.Write(request);
            isValid = double.TryParse(Console.ReadLine(), out userInput);

            while (isValid == false) {

                Console.WriteLine("ERROR: NO REAL NUMBER");
                Console.Write(request);
                isValid = double.TryParse(Console.ReadLine(), out userInput);
            }

            return userInput;

        }//END PROMPT DOUBLE
        #endregion
    }//END CLASS
}//END NAMESPACE

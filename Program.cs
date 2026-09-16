/*
Callen Thomason
9/15/2026
Challenge #2 - Guess It
I used a switch statement to select the difficulty. I then used do while loops and while loops for validation. 
If statements to make comparisons of numerical values. 
I used TryParse for validation, ensuring the user input a number
Peer Reviewer: Zionn Showers
Review: Code seems to run fine. However, it feels like the coding and drawio image is way more complicated than it could've been,
creating entirely new variables instead reusing other variables. It also doesn't seem count how many tries it took to find the
correct number.
*/

Console.Clear();
Random rnd = new Random();
string yesNo = "";
Console.WriteLine("Welcome to number guesser");
do
{
    Console.Write("Do you want to play Easy(A), Medium(B), Hard(C) or Custom(D): ");
    string userAns = Console.ReadLine().ToUpper();
    bool isValid = false;
    while (isValid == false)
    {
        switch (userAns)
        {
            case "A":
                Console.WriteLine("You selected easy");
                bool guessed = false;
                isValid = true;
                int min = 1;
                int max = 11;
                Console.WriteLine("Min: " + min);
                Console.WriteLine("Max: " + max);
                int randomNum = rnd.Next(min, max);
                //Console.WriteLine(randomNum);
                Console.Write("Please guess my number between 1 - 10: ");

                string userNum = Console.ReadLine();
                bool isNum = int.TryParse(userNum, out int newNum);
                while (guessed == false)
                {
                    while (isNum == false || newNum > 10 || newNum < 1)
                    {
                        Console.Write("Invalid input. Input a number:");
                        userNum = Console.ReadLine();
                        isNum = int.TryParse(userNum, out newNum);
                    }//end of while

                    if (newNum == randomNum)
                    {
                        Console.Write("You guessed right!");
                        guessed = true;
                        break;
                    }//end if
                    else if (newNum > randomNum)
                    {
                        Console.Write("Your guess is too high");
                    }//end else if
                    else
                    {
                        Console.Write("Your guess is too low");
                    }//end else
                    Console.Write("Guess again: ");
                    userNum = Console.ReadLine();
                     isNum = int.TryParse(userNum, out newNum);
                }//end of while loop

                break;
            case "B":
            /**/
                Console.WriteLine("You selected Medium");
                bool guessed1 = false;
                isValid = true;
                int min1 = 1;
                int max1 = 50;
                Console.WriteLine("Min1: " + min1);
                Console.WriteLine("Max1: " + max1);
                int randomNum1 = rnd.Next(min1, max1);
                //Console.WriteLine(randomNum);
                Console.Write("Please guess my number between 1 - 50: ");

                string userNum1 = Console.ReadLine();
                bool isNum1 = int.TryParse(userNum1, out int newNum1);
                while (guessed1 == false)
                {
                    while (isNum1 == false || newNum1 > 50 || newNum1 < 1)
                    {
                        Console.Write("Invalid input. Input a number:");
                        userNum1 = Console.ReadLine();
                        isNum1 = int.TryParse(userNum1, out newNum1);
                    }//end of while

                    if (newNum1 == randomNum1)
                    {
                        Console.Write("You guessed right!");
                        guessed1 = true;
                        break;
                    }//end if
                    else if (newNum1 > randomNum1)
                    {
                        Console.Write("Your guess is too high");
                    }//end else if
                    else
                    {
                        Console.Write("Your guess is too low");
                    }//end else
                    Console.Write("Guess again: ");
                    userNum1 = Console.ReadLine();
                     isNum1 = int.TryParse(userNum1, out newNum1);
                }//end of while loop

                break;
            case "C":
          Console.WriteLine("You selected Hard");
                bool guessed3 = false;
                isValid = true;
                int min3 = 1;
                int max3 = 100;
                Console.WriteLine("Min1: " + min3);
                Console.WriteLine("Max1: " + max3);
                int randomNum3 = rnd.Next(min3, max3);
                //Console.WriteLine(randomNum);
                Console.Write("Please guess my number between 1 - 100: ");

                string userNum3 = Console.ReadLine();
                bool isNum3 = int.TryParse(userNum3, out int newNum3);
                while (guessed3 == false)
                {
                    while (isNum3 == false || newNum3 > 100 || newNum3 < 1)
                    {
                        Console.Write("Invalid input. Input a number:");
                        userNum3 = Console.ReadLine();
                        isNum3 = int.TryParse(userNum3, out newNum3);
                    }//end of while

                    if (newNum3 == randomNum3)
                    {
                        Console.Write("You guessed right!");
                        guessed3 = true;
                        break;
                    }//end if
                    else if (newNum3 > randomNum3)
                    {
                        Console.Write("Your guess is too high");
                    }//end else if
                    else
                    {
                        Console.Write("Your guess is too low");
                    }//end else
                    Console.Write("Guess again: ");
                    userNum3 = Console.ReadLine();
                     isNum3 = int.TryParse(userNum3, out newNum3);
                }//end of while loop
               
                break;
            case "D":
                Console.WriteLine("You selected Custom");
                bool guessed4 = false;
                isValid = true;
                //int min4;
                //int max4;
                Console.Write("Please input a minimum: ");
                string userMin = Console.ReadLine(); 
                bool isMin = int.TryParse(userMin, out int min4);
                while(isMin == false)
                {
                    Console.Write("Invalid input. Input a number minimum:");
                    userMin = Console.ReadLine();
                     isMin = int.TryParse(userMin, out min4); 
                }//end of while

                Console.Write("Please input a maximum: ");
                 string userMax = Console.ReadLine(); 
                bool isMax = int.TryParse(userMax, out int max4);
                while(isMax == false || max4 < min4)
                {
                    Console.Write("Invalid input. Input a number minimum:");
                    userMax = Console.ReadLine();
                     isMax = int.TryParse(userMax, out max4); 
                }//end of while 


                Console.WriteLine("Min1: " + min4);
                Console.WriteLine("Max1: " + max4);
                int randomNum4 = rnd.Next(min4, max4);
                //Console.WriteLine(randomNum);
                Console.Write($"Please guess my number between {min4} - {max4}: ");

                string userNum4 = Console.ReadLine();
                bool isNum4 = int.TryParse(userNum4, out int newNum4);
                while (guessed4 == false)
                {
                    while (isNum4 == false || newNum4 > max4 || min4 < 1)
                    {
                        Console.Write("Invalid input. Input a number:");
                        userNum4 = Console.ReadLine();
                        isNum4 = int.TryParse(userNum4, out newNum4);
                    }//end of while

                    if (newNum4 == randomNum4)
                    {
                        Console.Write("You guessed right!");
                        guessed4 = true;
                        break;
                    }//end if
                    else if (newNum4 > randomNum4)
                    {
                        Console.Write("Your guess is too high");
                    }//end else if
                    else
                    {
                        Console.Write("Your guess is too low");
                    }//end else
                    Console.Write("Guess again: ");
                    userNum4 = Console.ReadLine();
                     isNum4 = int.TryParse(userNum4, out newNum4);
                }//end of while loop
               
                break;
            default:
                Console.WriteLine("Invalid input");
                Console.WriteLine("Do you want to play Easy(A), Medium(B), Hard(C) or Custom(D)");
                Console.WriteLine("Enter A, B, C, or D: ");
                userAns = Console.ReadLine().ToUpper();
                break;

        }//end of switch userAns
    }//end of while loop (invalid input)
    Console.Write("Do you want to play again Y / N: ");
    yesNo = Console.ReadLine().ToUpper();
    while (yesNo != "Y" && yesNo != "N")
    {
        Console.WriteLine("Invalid input. Please answer Y / N");
        yesNo = Console.ReadLine().ToUpper();
    }
} while (yesNo == "Y");

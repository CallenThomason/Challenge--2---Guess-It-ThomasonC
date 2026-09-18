/*
Callen Thomason
9/18/2026
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
Console.WriteLine("Welcome to number guesser");
GuessIt play = new GuessIt(); 
do{
 Console.Write("Do you want to play Easy(A), Medium(B), Hard(C) or Custom(D): ");
play.Difficulty(Console.ReadLine().ToUpper()); 
do{
        bool didConvert = play.MakeGuess(); 
       if(didConvert == false)
        {
            Console.WriteLine("Invalid Input"); 
        }
        play.CheckGuess(); 
       
        

 }while(!play.success);   
}while(GuessIt.PlayAgain()); 

Console.WriteLine("Thank you for playing"); 
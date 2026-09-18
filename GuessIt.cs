

public class GuessIt
{
    public int min = 1; 
    public int max = 2; 

    public int guess; 

    public int secretNum; 

    public bool success = false; 

    public void Difficulty(string answer)
    {
        Random rnd = new Random(); 
      success = false; 
        bool isValid = false; 
        while(!isValid){
        switch(answer){
            case "A":
           Console.WriteLine("You selected Easy.");
            max = 10; 
            isValid = true; 
            break;
            case "B":
            Console.WriteLine("You selected Medium.");
            max = 50; 
             isValid = true; 
            break;
            case "C":
            Console.WriteLine("You selected Hard.");
            max = 100;
             isValid = true; 
            break;
            case "D":
              Console.Write("Please input a minimum: ");
             string userMin = Console.ReadLine(); 
                bool isMin = int.TryParse(userMin, out min);
                while(isMin == false)
                {
                    Console.Write("Invalid input. Input a new Minimum:");
                    userMin = Console.ReadLine();
                     isMin = int.TryParse(userMin, out min); 
                }//end of while

                Console.Write("Please input a maximum: ");
                 string userMax = Console.ReadLine(); 
                bool isMax = int.TryParse(userMax, out max);
                while(isMax == false || max < min)
                {
                    if(max < min)
                        {
                            Console.WriteLine("Invalid Input: Max can not be lower than min"); 
                            Console.Write("Input a new Maximum:");
                        }
                     else{
                    Console.Write("Invalid input. Input a new Maximum:");
                    }
                    userMax = Console.ReadLine();
                     isMax = int.TryParse(userMax, out max); 
                }//end of while 
             isValid = true; 
            break;
            default: 
            Console.WriteLine("Invalid input. Please enter A, B, C, or D: ");
            answer = Console.ReadLine().ToUpper(); 
           
            break; 
        }//end of switch
        } //end of while
        secretNum = rnd.Next(min, max + 1); 
    }//end of method difficulty

public bool isAllowed; 
     public bool MakeGuess()
    {
        Console.WriteLine($"Guess a number between {min} - {max}");
        isAllowed = int.TryParse(Console.ReadLine(), out guess);
       return  isAllowed;
    }
    
     public void CheckGuess()
    {
        if(isAllowed == true){
        if (guess > secretNum && guess < max+1)
        {
            Console.WriteLine("Too High");
           // return false; 
        }
        else if(guess < secretNum && guess > min - 1)
        {
            Console.WriteLine("Too low");
           // return false; 
        }
        else if(guess > max || guess < min)
        {
            Console.WriteLine("Erorr: Input out of bounds"); 
        }
        else
        {
            Console.WriteLine("You got it!");
            success = true; 
           // return true; 
        }
        }//end if 
        else
        {
            Console.WriteLine("Erorr: Input must be a number"); 
        }
    }
    public static bool PlayAgain()
{
     Console.Write("Do You want to Play Again? Y/N:  ");
    string ans = Console.ReadLine().ToUpper();  
    while(ans != "Y" && ans != "N")
        {
          Console.Write("Invalid input, answer Y or N :  ");
             ans = Console.ReadLine().ToUpper(); 

        }
        if(ans == "Y")
        {
          return true;   
        }
        return false; 
}


}//end of class GuessIt
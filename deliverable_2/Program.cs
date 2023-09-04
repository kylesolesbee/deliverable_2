//Kyle Solesbee 
//Deliverable 2

using System;


Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Welcome " + name + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
string answer  = Console.ReadLine();
if (answer == "Yes" ){

    int score = 0;

    for(int i = 0; i < 5; i++){
        Random random = new Random();
        int result = random.Next(1, 3);
        Console.WriteLine("Heads or Tails?");
        string userChoice = Console.ReadLine();
        
        if (userChoice == "Heads"){ 
            
            if (result == 1) {
                Console.WriteLine("Correct!");
                score++;
            }
            
        }else if (userChoice == "Tails"){

            if (result == 2) {
                Console.WriteLine("Correct!");
                score++;
            }
        } else {
            Console.WriteLine("Wrong!");
        }
    }

    Console.WriteLine("Thank you " + name + ". You got a score of " + score);

}
else {
    Console.WriteLine("You are a coward " + name);
}


using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
    Dice(); //Inititates the Method
  }

  public static void Dice (){
    Write("What is your Name: "); 
    var pName = ReadLine();
    var wantP = true;
    int score = 0;
    while(wantP == true){    //initiates a loop to run the code
      Random rand = new Random();
      int roll = rand.Next(1,7);//creates a random number between 1 and 6
      WriteLine("{0} was rolled", roll);
      if (roll == 6){
        score = 0;
        wantP = false; //Ends the game if the roll is 6
      }
      else{
        score += roll;
        Write("\n Do you want to roll again? Y/N: ");
        var reroll = ReadLine();
        
        
        if (reroll != "Y"){ 
          wantP = false; //ends the game if user input isnt Y

        }
          
        
      }

    }
    WriteLine("\n {0} score was {1}",pName, score);



  }
}
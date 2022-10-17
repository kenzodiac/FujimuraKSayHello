//Kenneth Fujimura
//09-12-2022 @ 9:08pm
//Mini Challenge #1 - Say Hello
//This is a console project that will ask a user their name and report it back to them with a greeting.
//Peer Review by: Rafael Manzo, LOTS OF CODE! good stuff, game runs well. kudos.!!

Console.Clear();

bool playAgain = true;

//play again while loop
while (playAgain == true) {

    //main program
    Console.WriteLine("Hello, what is your name? ");
    string myName = Console.ReadLine();
    Console.WriteLine("Greetings, " + myName + ". It's nice to meet you!");

    //play again prompt with input validation
    Console.WriteLine("Would you like to play again? Y/N");
    bool answerCheck = true;
    while (answerCheck == true) {
        string playAgainInput = Console.ReadLine();
        if (playAgainInput == "y" || playAgainInput == "Y") {
            answerCheck = false;
            continue;
        } else if (playAgainInput == "n" || playAgainInput == "N"){
            playAgain = false;
            answerCheck = false;
        } else {
            Console.WriteLine("I do not understand. Please answer with 'Y' for yes, or 'N' for no.");
            answerCheck = true;
        }
    }
}
Console.WriteLine("Bye!");
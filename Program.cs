//Kenneth Fujimura
//10-17-2022
//GitHub Challenge #1 - Say Hello
//This is a console project that will ask a user their name and report it back to them with a greeting.
//Peer Review by:

Console.Clear();

//declaring global variables
bool playAgain = true;
bool answerCheck = true;
string playAgainInput = "";

//play again while loop
while (playAgain == true) {

    //main program
    Console.WriteLine("Hello, what is your name? ");
    string myName = Console.ReadLine();
    Console.WriteLine("Greetings, " + myName + ". It's nice to meet you!");

    //play again prompt with input validation
    Console.WriteLine("Would you like to play again? Y/N");
    while (answerCheck == true) {
        playAgainInput = Console.ReadLine();
        playAgainInput = playAgainInput.ToLower();
        EvaluatePlayAgain();
    }
}
Console.WriteLine("Bye!");

//custom method to evaluate whether the player wants to play again.
void EvaluatePlayAgain(){
    if (playAgainInput == "y" || playAgainInput == "yes") {
            answerCheck = false;
        } else if (playAgainInput == "n" || playAgainInput == "no"){
            playAgain = false;
            answerCheck = false;
        } else {
            Console.WriteLine("I do not understand. Please answer with 'Y' for yes, or 'N' for no.");
            answerCheck = true;
        }
}
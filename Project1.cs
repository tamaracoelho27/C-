Console.WriteLine("Enter an integer between 5 and 10");
string? readResult;
bool validNumber = false;
int num = 0;


//iterate while validNumber is false and num is less than 5 or greater than 10
while (validNumber == false || (num<5 || num>10)){
    readResult = Console.ReadLine(); //read the user input 
    validNumber = int.TryParse(readResult, out num);//stores true in validNumber and the userinput in num
    if (validNumber && num>=5 && num<=10){
        Console.WriteLine($"Your input value ({num}) has been accepted"); 
        break;
    }
    if (!validNumber){
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }else{
        Console.WriteLine($"You entered {num}. Please enter a number between 5 and 10.");
    }
}

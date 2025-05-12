string? readResult; //stores the result as a string
string result = "";
Console.WriteLine("Enter a role (Administrator, Manager, User)");
readResult = Console.ReadLine(); //reads the user input
result =readResult.Trim().ToLower();
while (!result.Contains("administrator") && !result.Contains("manager") && !result.Contains("user")){
    Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name(Administrator, Manager, User)");
    readResult = Console.ReadLine(); //reads the user input
    result =readResult.Trim().ToLower();   

}
Console.WriteLine($"Your input value ({readResult}) has been accepted");


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
for (int i= 0; i<myStrings.Length; i++){
    string myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    while (periodLocation!=-1){ //repeats until there is no period
        Console.WriteLine(myString.Substring(0, periodLocation).TrimStart());
        myString = myString.Remove(0,periodLocation+1);
        periodLocation = myString.IndexOf('.');
    }
    Console.WriteLine(myString.TrimStart());
}

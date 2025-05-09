//string [] fradulentOrderIDs = new string [3];
/*fradulentOrderIDs[0] = "A123";
fradulentOrderIDs[1]= "B456";
fradulentOrderIDs[2]= "C789";*/

string [] fradulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First element : {fradulentOrderIDs[0]}");
Console.WriteLine($"Second element: {fradulentOrderIDs[1]}");
Console.WriteLine($"Third element: {fradulentOrderIDs[2]}");

fradulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fradulentOrderIDs[0]}");

Console.WriteLine($"There are {fradulentOrderIDs.Length} fradulent orders to process");

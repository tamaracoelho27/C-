int hero = 10;
int monster = 10;
Random attack = new Random();
int attacks = 0;

while(hero>=0 && monster>=0){
    attacks = attack.Next(1,11);
    Console.WriteLine($"Monster was damaged and lost {attacks} health and now has {(monster -=attacks)} health"); 

    attacks = attack.Next(1,11);
    Console.WriteLine($"Hero was damaged and lost {attacks} health and now has {(hero -=attacks)} health");
}
if (monster>0){
    Console.WriteLine("Monster wins!");
}else{
    Console.WriteLine("Hero wins!");
}

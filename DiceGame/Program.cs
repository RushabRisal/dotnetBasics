using System;

//declare the dice for the game
Random dice = new();

//three rolling dice
int r1 = dice.Next(1,7);
int r2 = dice.Next(1,7);
int r3 = dice.Next(1,7);
int bonusPoint = 0;
int total = r1 + r2 + r3;
if(r1 == r2 || r1 == r3 || r2 == r3)
{
    if (r1 == r2 && r1 == r3)
        bonusPoint +=6;
    else
        bonusPoint+=2;
}
Console.WriteLine($"{r1}, {r2}, {r3}");
Console.WriteLine($"Total value: {total}");
Console.WriteLine($"bonus point: {bonusPoint}");
Console.WriteLine("Your result is:");
if((total + bonusPoint) >= 15)
{
    Console.WriteLine("You Won!!");
}
else
{
    Console.WriteLine("Sorry, You lost!");
}
//new task 
Random expiry =new();
int daysUntilExpiration = expiry.Next(12);
int discountPercentage = 0;
Console.WriteLine(daysUntilExpiration);
if(daysUntilExpiration <= 11)
{
    if (daysUntilExpiration <= 10)
    {
        if (daysUntilExpiration <= 5)
        {
            if (daysUntilExpiration == 1)
            {
                Console.WriteLine($"Your subscription expires within a days.\n Renew now and save {discountPercentage + 20}");
            }else if(daysUntilExpiration == 0)
                Console.WriteLine("Your subscription has expired.");
            else
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\n Renew now and save {discountPercentage + 10}");
        }
        else
            Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
    else
        Console.WriteLine();
}

  
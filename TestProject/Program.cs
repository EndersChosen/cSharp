Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
Console.WriteLine(daysUntilExpiration);

if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration <= 5)
    {
        if (daysUntilExpiration <= 1)
        {
            if (daysUntilExpiration < 1)
            {
                Console.WriteLine("Your subscription has expired");
            }
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 20 % !");
        }
    }

    else
    {
        Console.WriteLine("Your subscription expires within a day!\nRenew now and save 10 % !");
    }
}

else
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

int num = 9;

bool numCheck = true;

if (num <= 1)
{
    Console.WriteLine("1 den boyuk eded daxil edin");
}
else
{
    for (int i = 2; i <= num / 2; i++)
    {
        if (num % i == 0)
        {
            numCheck = false;
            break;
        }
    }
}
if (numCheck)
{
    Console.WriteLine("Sade ededdir");
}
else
{
    Console.WriteLine("Murekkeb ededdir");
}
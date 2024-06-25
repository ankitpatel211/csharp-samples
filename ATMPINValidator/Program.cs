string ATMPIN = "123456";
if (ATMPIN.Length == 4)
{
    if ((ATMPIN[0] == ATMPIN[1]) 
        || (ATMPIN[1] == ATMPIN[2])
        || (ATMPIN[2] == ATMPIN[3]) 
        || (ATMPIN[3] == ATMPIN[0]))
    {
        Console.WriteLine("This ATM PIN is invalid");
    }
    else
    {
        Console.WriteLine("This ATM PIN is valid");
    }
}
else
{
    if ((ATMPIN[0] == ATMPIN[1]) 
        || (ATMPIN[1] == ATMPIN[2])
        || (ATMPIN[2] == ATMPIN[3]) 
        || (ATMPIN[3] == ATMPIN[4])
        || (ATMPIN[4] == ATMPIN[5]))
    {
        Console.WriteLine("This ATM PIN is invalid");
    }
    else
    {
        Console.WriteLine("This ATM PIN is valid");
    }
}


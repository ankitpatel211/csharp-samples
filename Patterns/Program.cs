for(int i = 0; i < 5; i++)
{
    Console.Write("\n");
    for (int j = 0; j < 5; j++)
    {
        if (i % 2 == 0 && j == 2)
        {
            Console.Write("\t1\t");
        } 
        else if (i / 2 == 1 && j % 2 == 0)
        {
            Console.Write("\t1\t");
        }
    }
}
#region Fəsillər
int ay = 7;
switch (ay)
{
    case 1:
        Console.WriteLine("Qış");
        break;
    case 2:
        Console.WriteLine("Qış");
        break;
    case 3:
        Console.WriteLine("Yaz");
        break;
    case 4:
        Console.WriteLine("Yaz");
        break;
    case 5:
        Console.WriteLine("Yaz");
        break;
    case 6:
        Console.WriteLine("Yay");
        break;
    case 7:
        Console.WriteLine("Yay");
        break;
    case 8:
        Console.WriteLine("Yay");
        break;
    case 9:
        Console.WriteLine("Payız");
        break;
    case 10:
        Console.WriteLine("Payız");
        break;
    case 11:
        Console.WriteLine("Payız");
        break;
    case 12:
        Console.WriteLine("Qış");
        break;
    default:
        Console.WriteLine("Düzgün rəqəm daxil edin");
        break;
}
        #endregion

        #region reqemlerin cemi
        {
            int say = 342;
            int netice = 0;
            while (say > 0)
            {
                netice += (say % 10);
                say = say / 10;
            }
            Console.WriteLine(netice);
        }
#endregion

#region Ededin sade ve murekkebliyi
{
    int counter = 0;
    int reqem = 13;
    if (reqem == 0 || reqem == 1)
    {
        Console.WriteLine("Daxil etdiyiniz eded ne sadedir ne murekkeb");

    }
    else
    {
        for (int i = 2; i < reqem; i++)


        {
            if (reqem % i == 0) { counter++; break; }



        }
        if (counter != 0)
            Console.WriteLine("Daxil etdiyiniz eded murekkebdir");
        else
            Console.WriteLine("Daxil etdiyiniz eded sadedir");

    }
}

#endregion
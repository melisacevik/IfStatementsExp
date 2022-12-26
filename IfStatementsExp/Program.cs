internal class Program
{
    private static void Main(string[] args)
    {


        #region If Statements Gender Example;

        /*
        bool isMale = true;
        bool isTall = true;

        if ( isMale && isTall) // eğer erkek ve uzunsa
        {
            Console.WriteLine("You are a tall male");
        }
        else // erkek olmayabilir, uzun olmayabilir veya ikisi olmayabilir.
        {
            Console.WriteLine("You are either not male or not tall or both");
        }

        Console.ReadLine();

        // bool isMale yukarıda True olarak atandığı için output : You are a tall male olacak.
        // || olduğunda iki durumdan biri olacak && olduğunda 2 durumu da karşılamak zorunda.

        /* male but not tall? 
        * 
        bool isMale = true;
        bool isTall = true;

        if (isMale && isTall)
        {
            Console.WriteLine("You are a tall man ");
        }
        else if (isMale &&  !isTall) // ( erkek && uzun değil)
        {
            Console.WriteLine(" Your are a short male"); 
        }
        else if (!isMale && isTall) // ( erkek değil && uzun)
        {
            Console.WriteLine(" Your are not a male but you are tall");
        }
        else
        {
            Console.WriteLine("You are not male and not tall");
        }

        // bool 2 durumda da true ise if yazdırılıyor. or durumunda else if
        // 2 durumda da false ise else yazdırılıyor. */

        #endregion


    }
}
using StructNameSpace;

namespace Program
{
    public class program
    {
        static void Main(string[] args)
        {
            TimeStruct time = new TimeStruct ();
            time.Seconds = 10;

            Console.WriteLine (time.Seconds);
        }


    }
}
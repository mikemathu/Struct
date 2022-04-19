using StructNameSpace;

namespace Program
{
    public struct program
    {
        public static void Main(string[] args)
        {
            TimeStruct time = new TimeStruct();
            time.Seconds = 10;
            UpdateTime(time);

           
        }
        public static void UpdateTime(TimeStruct time)
        {
            time.Seconds++;
            Console.WriteLine(time);
        }
    }
}
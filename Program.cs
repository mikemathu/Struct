//using StructNameSpace;
using WrapperStruct;

namespace ProgramNameSpace
{
    public struct Program
    {
        //TIMESTRUCT PROGRAMS
        /*
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
        */

        //WRAPPER PROGRAM
        public static void Main(string[] args)
        {
            Wrapper wrapper = new Wrapper();
            wrapper.numbers = new int[3] { 40, 20, 30 };
            UpdateArray(wrapper);
            Console.WriteLine(wrapper.numbers);
        }
        public void UpdateArray(Wrapper wrapper)
        {
            wrapper.numbers[1] = 200;
            Console.WriteLine(wrapper.numbers[1]);
        }




    }
}
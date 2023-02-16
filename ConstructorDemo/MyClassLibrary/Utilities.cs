namespace MyClassLibrary
{
    public static class Utilities
    {
        static public bool isOdd(int i)
        {
            OtherUtilities.DoSomething();
            return i % 2 == 1;
        }

        //static public void DoSomething() => Console.WriteLine("dgghfgh");
    }

    static internal void DoSomething()
    {

    }

}
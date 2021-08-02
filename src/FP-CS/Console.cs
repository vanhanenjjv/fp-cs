namespace FP_CS
{
    public static class Console
    {
        public static Unit Write(string str)
        {
            System.Console.Write(str);
            return new Unit();
        }

        public static Unit WriteLine(string str)
        {
            System.Console.WriteLine(str);
            return new Unit();
        }
    }
}

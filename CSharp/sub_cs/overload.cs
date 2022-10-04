class OverloadingExample{
    static void F() => Console.WriteLine("F()");
    static void F(int x) => Console.WriteLine("F(int)"+x);

    public static void UsageExample(){
        F();
        F(889);
    }
}
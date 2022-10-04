public static class get_set{
    public static int return_value;
    public static int get_set_test{
        get => return_value;
        set {
            return_value = value;
            Console.WriteLine("set");
        }
    }
}
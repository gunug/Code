namespace root{
    public class generic_sample{
        public static void ShowText<T>(T t1, T t2){
            Console.WriteLine (t1+":"+t2);
        }
        public static void CallShow(){
            ShowText(1.2f, 1.3f);
            ShowText(3,5);
            ShowText("A","B");
        }
    }

    public class generic_class<T>{
        
        //static T test;
        public generic_class(T i1, T i2){
            
        }
    }
}
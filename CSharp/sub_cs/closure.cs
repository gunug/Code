public static class closure{

    public static void start_sample(){
        for(int i=0; i<5; i++){
            Console.WriteLine(i);
        }
    }

    public static void lambda_sample(){
        var b = () => {
            Console.WriteLine("test");
            return "test";
        };
        Console.WriteLine(b);
        
        for(int i=0; i<5; i++){
            Console.WriteLine(i);
            Func<int> a = () => { 
                Console.WriteLine("lambda:"+i);
                return i;
            };
            Console.WriteLine("lambda_return:"+a);
        }
    }

    public static void sample(){
        test1();
    }
    public static void test1(){
        for(int i=0; i<3; i++){
            test2(()=>{return 1;});
        }
    }
    public static void test2(Func<int> f){
        Console.WriteLine(f);
    }
}
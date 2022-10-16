
public static class lambda{
    public static int lambda_value = 0;
    public static void lambda_example(){
        // Expression lambdas
        var a = (string s) => int.Parse(s);
        // Statement lambdas
        var b = (string s) => { 
            int d = int.Parse(s); 
            return d;
        };

        var c = (int s) => {
            s++;
        };
    }

    public delegate int lambda_dele(int a);
    public static lambda_dele e = (int a) =>{
        Console.WriteLine(a);
        return 1+3;
    };
    public static void start_lambda(){
        e += (int a) => 4*5;
        e += (int a) => 6*7;
        Console.WriteLine(e(10));
    }
}
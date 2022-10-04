  using System.IO;
  
  namespace root{
    public class base_class{
        static void Main(String[] args) {
            Console.WriteLine("run!");
            Sub();

            delegate_sample del_sam = new delegate_sample();
            del_sam.init();

            generic_sample.CallShow();

            Constant con = new Constant();
            con.SaySomething();

            OverloadingExample.UsageExample();

            Console.WriteLine("---------------");
            Console.WriteLine(get_set.get_set_test);
            get_set.get_set_test = 999;
            Console.WriteLine(get_set.get_set_test);

            Console.WriteLine("---------------");
            array_example.array_sample();
        }
        static void Sub(){
            Console.WriteLine("Hello, World!");
        }        
    }
  }
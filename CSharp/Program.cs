  using System.IO;
  
  namespace root{
    public class base_class{
        static void Main(String[] args) {
            Console.WriteLine("run!");
            Sub();

            delegate_sample del_sam = new delegate_sample();
            del_sam.init();

            generic_sample.CallShow();
        }
        static void Sub(){
            Console.WriteLine("Hello, World!");
        }        
    }
  }
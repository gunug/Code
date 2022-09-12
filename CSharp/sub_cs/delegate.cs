using System.IO;
namespace root{
    public class delegate_sample{
        public void init(){
            // Instantiate the delegate.
            Del d1 = DelegateMethod;
            Del d2 = DelegateMethod2;
            Del handler = d1 + d2; //대리자를 덧샘으로 추가 가능
            handler += d2; //가산식 적용가능
            // 뺄샘이나 감산식 적용가능

            // Call the delegate.
            handler("delegate sample activate!");

            MethodWithCallback(0,1,handler);

            int invocationCount = handler.GetInvocationList().GetLength(0); //대리자에 포함된 메서드 숫자 알아내기
            Console.WriteLine("invocationCount:"+invocationCount);
        }

        public delegate void Del(string message);        

        public static void DelegateMethod(string message){
            Console.WriteLine(message);
        }
        public static void DelegateMethod2(string message){
            Console.WriteLine("is from 2 :"+message);
        }

        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }
    }
}
class Parent
{
  // 프로퍼티도 virtual 키워드 사용할 수 있습니다.
  public virtual string Str { get; set; }
  
  // 가상 메서드로 선언합니다.
  public virtual void show() 
  {
    Console.WriteLine("Parent의 show() 메서드");
  }
}

class Child : Parent
{
  // 프로퍼티도 재정의할 수 있습니다.
  public override string Str { get; set; }
  
  // show() 메서드를 재정의합니다.
  public override void show()
  {
    Console.WriteLine("Parent 클래스의 show() 메서드 오버로드");
  }
}

///
/*
오버로딩(Overloading)
매개변수와 반환 타입이 다르지만, 메서드 이름이 동일합니다.

오버라이딩(Overriding)
상위 클래스의 메서드를 하위 클래스에서 재정의합니다. 

오버로딩과 오버라이딩의 가장 큰 차이점은 오버로딩은 컴파일 시간에 작동하는 반면, 
오버라이딩은 런타임에 작동한다는 것입니다. virtual 키워드는 런타임에 실행되므로 메서드 오버라이딩 개념을 따릅니다.
*/
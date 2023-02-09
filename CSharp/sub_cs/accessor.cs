public class accessor{
    public int value1; //액세스가 제한되지 않음
    private int value2; //이 클래스로만 액세스가 제한됨
    protected int value3; // 이 클래스 또는 이 클래스에서 파생된 클래스로만 액세스가 제한됨
    internal int value4; // 액세스가 현제 어셈블리(.exe또는 .dll)로 제한됨
    protected internal int value5; //액세스가 이 클래스, 이클래스에서 파생된 클래스 또는 동일한 어셈블리 내의 클래스로만 제한됨
    private protected int value6; //액세스가 이클래스 또는 동일한 어셈블리내의 이 형식에서 파생된 클래스로만 제한됨

    public static readonly int value7; //읽기전용 정적변수

    public void etc(){
        value1 = 0;
        value2 = 0;
        Console.WriteLine(value2); //콘솔찍기 전에는 필드가 사용되지 않았습니다 warning뜨고 이거 있으니 안뜨는것 무엇
        value3 = 0;
        value4 = 0;
        value5 = 0;
        value6 = 0;
    }
    public static void etc_static(){
        int get_value = value7;
    }
}
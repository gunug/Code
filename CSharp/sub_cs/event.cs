public class MyList2<T>
{
    const int DefaultCapacity = 4;

    T[] _items;
    int _count;
    public int Count => _count;

    public MyList2(int capacity = DefaultCapacity)
    {
        _items = new T[capacity];
    }

    public int Capacity
    {
        get =>  _items.Length;
        set
        {
            if (value < _count) value = _count;
            if (value != _items.Length)
            {
                T[] newItems = new T[value];
                Array.Copy(_items, 0, newItems, 0, _count);
                _items = newItems;
            }
        }
    }

    public T this[int index]
    {
        get => _items[index];
        set
        {
            _items[index] = value;
            OnChanged();
        }
    }
    public void Add(T item)
    {
        if (_count == Capacity) Capacity = _count * 2;
        _items[_count] = item;
        _count++;
        OnChanged();
    }
    protected virtual void OnChanged() => Changed?.Invoke(this, EventArgs.Empty);

    public override bool Equals(object other) =>
    Equals(this, other as MyList2<T>);

    static bool Equals(MyList2<T> a, MyList2<T> b)
    {
        if (Object.ReferenceEquals(a, null)) return Object.ReferenceEquals(b, null);
        if (Object.ReferenceEquals(b, null) || a._count != b._count)
            return false;
        for (int i = 0; i < a._count; i++)
        {
            if (!object.Equals(a._items[i], b._items[i]))
            {
                return false;
            }
        }
        return true;
    }

    public event EventHandler Changed;

    public static bool operator ==(MyList2<T> a, MyList2<T> b) =>
        Equals(a, b);

    public static bool operator !=(MyList2<T> a, MyList2<T> b) =>
        !Equals(a, b);
}

class EventExample
{
    static int s_changeCount;
    
    static void ListChanged(object sender, EventArgs e)
    {
        s_changeCount++;
    }
    
    public static void Usage()
    {
        var names = new MyList2<string>();
        names.Changed += new EventHandler(ListChanged);
        names.Add("Liz");
        names.Add("Martha");
        names.Add("Beth");
        Console.WriteLine(s_changeCount); // "3"
    }
}
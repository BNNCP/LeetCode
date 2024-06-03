public class MyHashSet
{
    private LinkedList<int> list = new LinkedList<int>();
    public MyHashSet()
    {

    }

    public void Add(int key)
    {
        list.AddLast(key);
    }

    public void Remove(int key)
    {
        while (list.Find(key) != null)
        {
            list.Remove(key);
        }

    }

    public bool Contains(int key)
    {
        return list.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
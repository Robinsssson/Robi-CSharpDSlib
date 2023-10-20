namespace CS_Console
{
    interface IListOperate<T>
    {
        public void PushBack(T val);
        public T PopBack();
        public T GetBack(int index);
        public T GetValue(int index);
        public void SetValue(int index, T val);
        public void Clear();
        public bool Contains(T item);
        public ref T GetItem(int index);

    }
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> next {  get; set; }
        public Node() { Value = default; next = null; }

        public Node<T> GetNext() { return  next; }
    }
    public class LinkList<T> : IListOperate<T>
    {
        private readonly Node<T> L;
        public LinkList()
        {
            L = new Node<T>();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public T GetBack(int index)
        {
            throw new NotImplementedException();
        }

        public ref T GetItem(int index)
        {
            throw new NotImplementedException();
        }

        public T GetValue(int index)
        {
            throw new NotImplementedException();
        }

        public T PopBack()
        {
            if (L.next == null)
                return default;
            Node<T> node = L.next;
            while (node.next != null)
            {
                node = node.next;
            }
            T tmp = node.Value;
            return tmp;
        }

        public void PushBack(T val)
        {
            Node<T> N = new()
            {
                Value = val
            };
            L.next = N;
        }

        public void SetValue(int index, T val)
        {
            throw new NotImplementedException();
        }
    }
}

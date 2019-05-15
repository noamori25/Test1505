using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1505
{
    public class MyuUniqueList<T>
    {
        List<T> list = new List<T>();

        public bool Add(T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                return true;
            }
            else
            {
                throw new ItemAlreadyExistException($"{item} is already exsit");
            }
        }

        public bool Remove(T item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                return true;
            }
            else
            {
                throw new ItemNotFoundException($"{item} not found");
            }
        }

        public T Peek(int index)
        {
            if (index > list.Count - 1 || index < 0)
                throw new MyIndexOutOfRangeException($"{index} out of range the max index is {list.Count - 1}");
            return list[index];
        }

        public T this[int index]
        {
            get
            {
                if (index > list.Count - 1 || index < 0)
                    throw new MyIndexOutOfRangeException($"{index} out of range the max index is {list.Count - 1}");
                return this.list[index];
            }
            set
            {
                if (index > list.Count - 1 || index < 0)
                    throw new MyIndexOutOfRangeException($"{index} out of range the max index is {list.Count - 1}");
                if (list[index].Equals(value))
                    return;
                if (list.Contains(value))
                    return;
                list[index] = value;
            }
        }
    }
}

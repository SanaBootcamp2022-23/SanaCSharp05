using System.Collections;

namespace OOP1
{
    public class Flight : IList<AirPlane>
    {
        readonly List<AirPlane> planes = new();
        public int Count => planes.Count;
        public bool IsReadOnly => true;

        public AirPlane this[int index]
        {
            get => planes[index];
            set => Insert(index, value);
        }

        public void Add(AirPlane item)
        {
            planes.Add(item);
        }

        public void Clear()
        {
            planes.Clear();
        }

        public bool Contains(AirPlane item)
        {
            return planes.Contains(item);
        }

        public void CopyTo(AirPlane[] array, int arrayIndex)
        {
            planes.CopyTo(array, arrayIndex);
        }

        public IEnumerator<AirPlane> GetEnumerator()
        {
            return planes.GetEnumerator();
        }

        public int IndexOf(AirPlane item)
        {
            return planes.IndexOf(item);
        }

        public void Insert(int index, AirPlane item)
        {
            planes.Insert(index, item);
        }

        public bool Remove(AirPlane item)
        {
            return planes.Remove(item);
        }

        public void RemoveAt(int index)
        {
            planes.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
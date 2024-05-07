using System.Collections;

namespace VehicleApp
{
    public class DynamicCollection<T> : IEnumerable<T>
    {
        private List<T> elements = new List<T>();
        public void Add(T element)
        {
            elements.Add(element);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return elements.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02Collections
{
    internal class FixedSizeList<T>
    {
        public FixedSizeList(int capacity)
        {
            Capacity = capacity;
        }

        private static int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public List<T> Values { get; set; }=new List<T>(capacity);
        public void Add(T item) {
            try
            {
                Values.Add(item);
            }
            catch (Exception ex) {
                throw new IndexOutOfRangeException();
            }
        }
        public T GetValue(int index) {
            try
            {
                return Values[index];

            }
            catch (Exception ex) { throw new IndexOutOfRangeException(); }
        }
    }
}

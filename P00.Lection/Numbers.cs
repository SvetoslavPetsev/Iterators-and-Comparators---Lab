using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P00.Lection
{
    public class Numbers : IEnumerable<int>
    {

        private List<int> data;
        public Numbers(int[] numbers)
        {
            this.data = numbers.ToList();
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var number in this.data.Where(x => x % 2 == 0))
            {
                yield return number;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

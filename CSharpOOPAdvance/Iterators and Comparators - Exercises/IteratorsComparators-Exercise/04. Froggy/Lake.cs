using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _04.Froggy
{
    public class Lake<T> : IEnumerable<T>
    {
        private List<T> data;

        public Lake(params T[] items)
        {
            this.data = new List<T>(items);
        }

        public IEnumerator<T> GetEnumerator()
        {
            // 13, 23, 1, -8, 4, 9
            for (int i = 0; i < this.data.Count; i += 2)
            {
                yield return this.data[i];
            }

            var lastIndex = this.data.Count - 1;
            if (lastIndex % 2 == 0)
            {
                lastIndex--;
            }

            for (int i = lastIndex; i >= 0; i -= 2)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public string ForEach()
        {
            StringBuilder sb = new StringBuilder();
            IEnumerator<T> enumerator = this.GetEnumerator();
            while (enumerator.MoveNext())
            {
                sb.Append($"{enumerator.Current}, ");
            }

            return sb.ToString().TrimEnd(',',' ');
        }
    }
}

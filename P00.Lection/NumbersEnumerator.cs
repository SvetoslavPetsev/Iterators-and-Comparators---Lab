//namespace P00.Lection
//{
//    using System.Collections;
//    using System.Collections.Generic;

//    public class NumbersEnumerator : IEnumerator<int>
//    {
//        private int[] array;
//        private int index;

//        public NumbersEnumerator(int[] collection)
//        {
//            this.Reset();
//            this.array = collection;

//        }
//        public int Current => this.Current;

//        object IEnumerator.Current => throw new System.NotImplementedException();

//        public void Dispose()
//        {
//        }

//        public bool MoveNext()
//        {
//            this.index++;
//            return this.index < this.array.Length;
//        }

//        public void Reset()
//        {
//            this.index = -1;
//        }
//    }
//}

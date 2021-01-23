using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyDictonary<int, string> dictionary = new MyDictonary<int, string>();
            dictionary.Add(1, "value1");
            dictionary.Add(2, "value2");

           Console.WriteLine(dictionary.Count.ToString());
        }
    }


    class MyDictonary<K,T>
    {
        K[] _kArray;
        K[] _kTempArray;

        T[] _vArray;
        T[] _vTempArray;
        public MyDictonary()
        {
            _kArray = new K[0];
            _vArray = new T[0];
        }

        public void Add(K kItem, T vItem)
        {
            _kTempArray = _kArray;
            _kArray = new K[_kTempArray.Length + 1];

            for (int i = 0; i < _kTempArray.Length; i++)
            {
                _kArray[i] = _kTempArray[i];
            }

            _kArray[_kArray.Length - 1] = kItem;


            _vTempArray = _vArray;
            _vArray = new T[_vTempArray.Length + 1];

            for (int i = 0; i < _vTempArray.Length; i++)
            {
                _vArray[i] = _vTempArray[i];
            }

            _vArray[_vArray.Length - 1] = vItem;
        }

        public int Count
        {
            get { return _kArray.Length; }
        }
    }


}

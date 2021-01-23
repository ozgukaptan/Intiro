using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyDictonary<string> dictionary = new MyDictonary<string>();
            dictionary.Add("1", "value1");
            dictionary.Add("2", "value2");

           Console.WriteLine(dictionary.Count.ToString());
        }
    }


    class MyDictonary<T>
    {
        T[] _kArray;
        T[] _kTempArray;

        T[] _vArray;
        T[] _vTempArray;
        public MyDictonary()
        {
            _kArray = new T[0];
            _vArray = new T[0];
        }

        public void Add(T kItem, T vItem)
        {
            _kTempArray = _kArray;
            _kArray = new T[_kTempArray.Length + 1];

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

using System;
using System.Collections.Generic;

namespace Generics.Project
{
    public class DataStore<T> where T : class, new()
    {
        static int index = 10;
        T[] _data = new T[index]; // 
        T entry = new();
        Dictionary<string, T> _dataList = new Dictionary<string, T>();
        public DataStore()
        {

        }

        public void AddItem(T item)
        {
            if (_data[_data.Length - 1] == null) //_> Se ho spazio
            {
                var element = Array.IndexOf(_data,
                    Array.Find(_data, x => x == null));
                _data[element] = item;
            }
            else
            {
                T[] _nextData = new T[_data.Length + 4];
                Array.Copy(_data, _nextData, _nextData.Length);
                _data = _nextData;
            }
        }
        public T RetriveFromDictionary(string key)
        {
            if (_dataList is not null)
            {
                T valore = null;
                _dataList.TryGetValue(key, out valore);
                return valore;
            }
            else
            {
                return null;
            }
        }
        // Add
        // Get
        // Print
        public void Print()
        {
            var campi = entry.GetType().GetProperties();

            foreach (var prop in campi)
            {
                // p.Modello  ===  prop.Name; 
                // p.Marca  ===  prop.Name; 
                // p.NFactory  ===  prop.Name; 
            }
        }
    }
}

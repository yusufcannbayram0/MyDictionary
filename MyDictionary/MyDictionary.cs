using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<KT ,VT >
    {
        KT[] _keys;
        VT[] _values;

        public MyDictionary()
        {
            _keys = new KT[0];
            _values = new VT[0];
        }

        public void Add(KT key,VT value)
        {
            KT[] tempKeys = _keys;
            _keys = new KT[_keys.Length + 1];

            VT[] tempValues = _values;
            _values = new VT[_values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
            }
            _keys[_keys.Length - 1] = key;


            for (int j = 0; j < tempValues.Length; j++)
            {
                _values[j] = tempValues[j];
            }
            _values[_values.Length - 1] = value;

        }
    }
}

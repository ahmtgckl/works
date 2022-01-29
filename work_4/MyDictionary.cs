using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_4
{
    public class MyDictionary<TKey, TValue>
    {
        //Ekleme sağlayabilmek için alınacak değerlere dizi oluşturuldu.
        TKey[] _keys;
        TValue[] _values;

        //Mydictionary class new'lendiği zaman dizi boyutu 0 ayarlandı.
        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            //Geçiçi dizi tutucu oluşturuldu.       
            TKey[] tempKeyArray = _keys;

            //0 boyutlu diziye ilk eleman ekleneceğinden dizi boyutunu 1 genişletildi.
            _keys = new TKey[_keys.Length + 1];

            //Dizi içerisinde gezerek temparray elemanları geçiçi tutması sağlandı.
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                _keys[i] = tempKeyArray[i];
            }

            //Kullanıcıdan aldığımız değeri en son dizi elamanı gibi eklendi.
            _keys[_keys.Length - 1] = key;


            //Geçiçi dizi tutucu oluşturuldu 
            TValue[] tempValueArray = _values;

            //0 boyutlu diziye ilk eleman ekleneceği için dizi boyutunu 1 genişletildi 
            _values = new TValue[_values.Length + 1];

            //Dizi içerisinde gezerek temparray elemanları geçiçi tutması sağlandı.
            for (int i = 0; i < tempValueArray.Length; i++)
            {
                _values[i] = tempValueArray[i];
            }
            //Dışarıdan gönderilen key değerini dizinin en son elamnı olarak eklendi.

            _values[_values.Length - 1] = value;
        }
        public int length
        {
            get
            {
                return _keys.Length;
            }
        }

        public void Print()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine($"Key : {_keys[i]} | Value :{_values[i]}");
            }

        }
    }
}

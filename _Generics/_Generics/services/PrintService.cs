using System;
using System.Collections.Generic;
using System.Text;

namespace _Generics.services
{
    class PrintService<T>// Toda a classe PrintService ela é de um tipo genérico especifíco "T"
    {
        //Troquei int[] _values pra object[] _values
        private T[] _values = new T[10];
        private int _count = 0;

       

        public void AddValue(T value)
        {
            if (_count == 10)
                throw new InvalidOperationException("PrintService está cheio"); 
            _values[_count] = value;
            _count++;
        }
        public T First()
        {
            if (_count == 0)
                throw new InvalidOperationException("PrintService está vazio");
            return _values[0];
        }
        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count -1; i++)
            {
                Console.Write(_values[i] + ", ");
                
            }
            if (_count > 0)
            {
                Console.Write(_values[_count -1]);
            }
            Console.Write("]");
        }
    }
}

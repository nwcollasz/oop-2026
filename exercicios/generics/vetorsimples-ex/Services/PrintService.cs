using System;

namespace vetorsimples_ex.Services
{
    public class PrintService<T>
    {
        private T[] _valor = new T[10];
        private int _count = 0;

        public void AddCount(T value)
        {
            if (_count == 10)
            {
            throw new InvalidOperationException("PrintService está cheio");
            }
            _valor[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService está vazio");
            }
            
            return _valor [0];
        }


        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_valor[i] + ", ");
            }

            if (_count > 0)
            {
                Console.Write(_valor[_count - 1]);
            }
            
            Console.Write("]");
        }
    }
}
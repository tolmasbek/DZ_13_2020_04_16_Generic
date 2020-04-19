using System;
using System.Collections.Generic;
using System.Linq;

namespace DZ16042020Space
{
    public class ArrayHelper<T>
    {
        /*
            Pop(ref T []) – Удаляет последний элемент массива и возвращает этот
            удалённый элемент используя return.
        */
        public static T Pop(ref T[] arr)
        {
            T posledniy = arr[arr.Length - 1];
            T[] newArr = new T[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
            return posledniy;
        }
        /*
            Push(ref T [], элемент) – Добавляет элемент с конца массива и
            возвращает обновленную длину массива
        */
        public static int Push(ref T[] arr, T newElement)
        {

            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = newElement;

            return arr.Length;
        }

        /*
            Shift(ref T []) – Удаляет первый элемент и возвращает этот удалённый
            элемент используя return.
        */
        public static T Shift(ref T[] arr)
        {
            T firstElement = default(T);

            firstElement = arr[0];
            arr = arr.Skip(1).ToArray();

            return firstElement;
        }
        /*
            UnShift(ref T [], элемент) – Добавляет элемент в начало массива и
            возвращает обновленную длину массива
        */
        public static int UnShift(ref T[] arr, T newElement)
        {
            T[] newarr = arr.Prepend(newElement).ToArray();
            arr = newarr;
            return arr.Length;
        }
        /*
            Slice(T [], begin index, end index) – возвращает новый массив,
            содержащий копию части исходного массива
        */
        public static T[] Slice(T[] arr, int begin_index = 0, int end_index = 0)
        {
            List<T> new_arr = new List<T>();
            int size_arr = arr.Length;
            if (end_index == 0)
            {
                end_index = arr.Length;
            }
            if (begin_index > arr.Length - 1)
            {
                return new_arr.ToArray();
            }
            else
            {
                if (begin_index >= 0)
                {
                    if (end_index > 0)
                    {
                        for (int i = begin_index; i < end_index; i++)
                        {
                            new_arr.Add( arr[i] );
                        }
                    }
                    else 
                    if (end_index < 0)
                    {
                        for (int i = begin_index; i < (size_arr + end_index); i++)
                        {
                            new_arr.Add( arr[i] );
                        }
                    }
                }
                else 
                if (begin_index < 0)
                {
                    for (int i = 0; i < (size_arr + begin_index); i++)
                    {
                        new_arr.Add( arr[i] );
                    }
                }
                return new_arr.ToArray();
            }
        }
    }
}
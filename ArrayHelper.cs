
namespace DZ16042020
{
    public class ArrayHelper
    {
        /*
            Pop(ref T []) – Удаляет последний элемент массива и возвращает этот
            удалённый элемент используя return.
        */
        public static T Pop<T>(ref T[] arr)
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
        public static T Push<T>(ref T[] arr, T newElement)
        {
            
        }
        public static T Shift<T>(ref T[] arr)
        {

        }
        public static T UnShift<T>(ref T[] arr, T newElement)
        {

        }
        public static T Slice<T>(ref T[] arr)
        {

        }
    }
}
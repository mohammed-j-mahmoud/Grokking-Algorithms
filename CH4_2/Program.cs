
class CH4_2
{

    public static int Count(int[] arr)
    {
        if (arr.Length == 1)
        {
            return 1;
        }
        int[] arr2 = new int[arr.Length - 1];
        Array.Copy(arr, 1, arr2, 0, arr.Length - 1);
        return 1 + Count(arr2);

    }
    public static int GetMax(int[] arr)
    {
        if (arr.Length == 1)
        {
            return arr[0];
        }

        int[] arr2 = new int[arr.Length - 1];

        if (arr[0] < arr[1])
        {
            Array.Copy(arr, 1, arr2, 0, arr.Length - 1);
            return GetMax(arr2);
        }
        //arr[0] > arr[1]
        arr[1]= arr[0];
        Array.Copy(arr, 1, arr2, 0, arr.Length - 1);
        return GetMax(arr2);
    }
    public static int GetMax2(int[] arr)//much better 
    {
        if (arr.Length == 2)
        {
            return  arr[0] > arr[1] ? arr[0] : arr[1];
        }

        int[] arr2 = new int[arr.Length - 1];
        Array.Copy(arr, 1, arr2, 0, arr.Length - 1);

        return arr[0] > GetMax2(arr2) ? arr[0] : GetMax2(arr2);
    }
    public static int GetMin2(int[] arr)//much better // ;D
    {
        if (arr.Length == 2)
        {
            return arr[0] < arr[1] ? arr[0] : arr[1];
        }

        int[] arr2 = new int[arr.Length - 1];
        Array.Copy(arr, 1, arr2, 0, arr.Length - 1);

        return arr[0] < GetMin2(arr2) ? arr[0] : GetMin2(arr2);
    }
    public static int GetMin(int[] arr)
    {
        if (arr.Length == 1)
        {
            return arr[0];
        }

        int[] arr2 = new int[arr.Length - 1];

        if (arr[0] > arr[1])
        {
            Array.Copy(arr, 1, arr2, 0, arr.Length - 1);
            return GetMin(arr2);
        }
        //arr[0] < arr[1]
        arr[1] = arr[0];
        Array.Copy(arr, 1, arr2, 0, arr.Length - 1);
        return GetMin(arr2);
    }

    public static string BinarySearch(int[] arr, int number)
    {
        if (arr.Length == 0)
        {
            return "Not In The Array";
        }
        int midIndex = arr.Length/2;
        int midValue = arr[midIndex];
        if (midValue == number)
        {
            return "Found In The Array";
        }

        if (midValue > number)
        {
            if (arr.Length % 2 == 0)
            {
                int[] arr2 = new int[arr.Length - midIndex];
                Array.Copy(arr, 0, arr2, 0, arr.Length - midIndex);
                return BinarySearch(arr2, number);
            }
            else//odd Array Lenght
            {
                int[] arr2 = new int[arr.Length - midIndex - 1 ];
                Array.Copy(arr, 0, arr2, 0, arr.Length - midIndex - 1 );
                return BinarySearch(arr2, number);
            }
        }
        else //midValue < number
        {
            if (arr.Length % 2 == 0)
            {
                int[] arr2 = new int[arr.Length - midIndex - 1 ];
                Array.Copy(arr,(midIndex + 1) , arr2, 0, arr.Length - midIndex - 1 );
                return BinarySearch(arr2, number);
            }
            else//odd Array Lenght
            {
                int[] arr2 = new int[arr.Length - midIndex - 1];
                Array.Copy(arr,(midIndex + 1), arr2, 0, arr.Length - midIndex - 1 );
                return BinarySearch(arr2, number);
            }
        }
    }

    static void Main()
    {
        


        int[] myNum = { -16, 2, 3, 4, 5,-1,5,-100,0,1,-100 };
        //Array.Sort(myNum);
        //int[] myNum = { 3,4};
        //bool ArrayLenghtisEven=false;
        //if (myNum.Length %2 == 0)
        //{
        //    ArrayLenghtisEven=true;
        //}
        int Note = CH4_2.GetMin2(myNum);
        Console.WriteLine($"max number Is :{Note} ");
    }

}
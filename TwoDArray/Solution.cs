//com.coffey.niall 21/03/2017
//We define an hourglass in  to be a subset of values with indices falling in this pattern in 
//graphical representation:
//a b c
//  d
//e f g
//hourglass sum is the sum of an hourglass' values.
//1 1 1 0 0 0
//0 1 0 0 0 0
//1 1 1 0 0 0
//0 0 0 0 0 0
//0 0 0 0 0 0
//0 0 0 0 0 0

//e.g. first hourglass
//1 1 1
//  1  
//1 1 1



//Task
//Calculate the hourglass sum for every hourglass in array then print the maximum hourglass sum. 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int[][] arr = new int[6][];
        for (int arr_i = 0; arr_i < 6; arr_i++)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
        }

        int maximumHourGlass = Int32.MinValue;
        //loop through array
        //check if hourglass is possible
        //check if outer dimension is less than 4
        //check is inner dimension is  less than 4

        //iterate as long as hourglass is possible
        for (int i = 0; i < arr.GetLength(0) - 2; i++)
        {


            //iterate as long as hourglass is possible
            for (int j = 0; j < arr.GetLength(0) - 2; j++)
            {
                //here we sum the hourglass
                int temp = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                + arr[i + 1][j + 1]
                    + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                //if its bigger replace the maximum
                if (temp > maximumHourGlass)
                {
                    maximumHourGlass = temp;
                }

            }
        }
        Console.WriteLine(maximumHourGlass);

    }
}


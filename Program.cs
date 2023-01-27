using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Xml.Schema;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(decimal[] arr)
    {
        decimal min = 0;
        decimal max = 0;
        int array_length_save = arr.Length;
        int array_length = 0;
        decimal array_min_index = 0;
        decimal array_max_index = 0;
        
        // array_length++;
      //  Console.Write(arr[0]);
        do
        {
            if (arr[array_length] < min)
            {
                min = arr[array_length];
                array_min_index = array_length;
            }
            array_length++;
        }
        while (array_length != array_length_save);


        array_length = 0;
        array_length_save = arr.Length;
        do
        {
            if (arr[array_length] > max)
            {
                max = arr[array_length];
                array_max_index = array_length;
            }
            array_length++;
        }
        while (array_length != array_length_save);


        decimal maxsum = 0;
        decimal minsum = arr[(int)(array_min_index)] + arr[(int)(array_min_index + 1)] + arr[(int)(array_min_index + 2)] + arr[(int)(array_min_index + 3)];
        if (array_max_index != 0)
        {
             maxsum = arr[(int)(array_max_index)] + arr[(int)(array_max_index - 1)] + arr[(int)(array_max_index - 2)] + arr[(int)(array_max_index - 3)];
        }
        else
        {
            maxsum = minsum;
        }
        //Console.WriteLine(minsum + " " + maxsum);
        Console.Write(minsum);
        Console.Write(" ");
        Console.Write(maxsum);
        Console.Write("\n");
       // Console.WriteLine("Enter any key to continue");

        return;

    }


    class Solution
    {

        public static void Main(string[] args)
        {

            // int[] arr = new int[5];
            //  for (int i = 0; i < arr.Length; i++)
            //  {
            //      arr[i] = Convert.ToInt32(Console.Read());
            //
            //
       Console.Write("Enter line of numbers");
            string[] input = new string[9];
            string[] subinputx = new string[5];
            //  for (int i = 0; i < input.Length; i++)
            //  {
            //     input[i] = Console.Read().
            //         ToString();
            //     if (input[i] != "32")
            //     {
            //        subinputx[i] = input[i];
            //    }
            //}
            string inputx = Console.ReadLine();
            
            //for (int i = 0; i < input.Length; i++)
            //{
                input = inputx.Split(" ");
                Array.Sort(input);
            //}
            //string[] subarrx = new string[5];
           // subinputx[0] = input[0];
           // subinputx[1] = input[2];
           // subinputx[2] = input[4];
           // subinputx[3] = input[6];
           // subinputx[4] = input[8];
            //  NumberStyles style = NumberStyles.Integer;
            // CultureInfo culture = CultureInfo.CreateSpecificCulture("31-7F"); 
          // string[] subnumbers = new string[5];
          //  string[] subdec = new string[5];
            decimal[] arr = new decimal[5];
          //  byte[] bytenum = new byte[5];            
          // for (int i = 0; i < subarrx.Length; i++)
          //  {
           //     bytenum = Encoding.ASCII.GetBytes(subarrx[i]);
              // subnumbers[i] = (byte)(subarrx[i]);

             //   if (subnumbers[i].Length < 3)
             //       subnumbers[i] = subarrx[i].PadLeft(1, '0');
             
              //  subarrx[i] += subnumbers[i];
           // }

          //  foreach (byte b in bytenum)
           // {
                for (int i = 0; i < input.Length; i++)
                {
   
                 // arr[i] = Convert.ToDecimal(subarrx[i]);


                    if (decimal.TryParse(input[i], out decimal value)) // ideally use the overload with NumberStyles.Any and CultureInfo.CurrentCulture to be explicit.
                    {
                        //Console.WriteLine($"Output: {value}");
                        arr[i] = value;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
           
          Console.Write("\n");
          Console.Write(arr[0]);
          Console.Write(arr[1]);
          Console.Write(arr[2]);
          Console.Write(arr[3]);
          Console.Write(arr[4]);
          Console.Write("\n");



            Result.miniMaxSum(arr);
        }
    }
}

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

namespace Jumping_on_the_Clouds
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c);

            // textWriter.WriteLine(result);

            // textWriter.Flush();
            // textWriter.Close();
            Console.WriteLine("Hello World!");
        }

        static int jumpingOnClouds(int[] c) {
            int len = c.Count();
            int jump = 0, i ;
            for( i = 0 ; i < len - 2 ; i ++)
            {   
                if ( c[i] == 0 && c[i+1] == 0 && c[i + 2] == 0)
                {
                    jump++; i++; continue;
                }
                else if ( c[i] == 0 && c[i+1] == 0 && c[i + 2] == 1)
                {
                    jump++; continue;
                }
                else if (c[i+1] == 1)
                {
                    jump++; i++;
                }
            }
            if(i == len -2) jump++;
            return jump;

        }
    }
}

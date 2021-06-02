﻿using System;
using System.Collections.Generic;
using System.Linq;

//Starting example for myself to familirize with which is taken from mircrosoft page
//int[] scores = new int[] { 97, 92, 81, 60 };

//// Define the query expression.
//IEnumerable<int> scoreQuery =
//    from score in scores
//    where score > 80
//    select score;

//// Execute the query.
//foreach (int i in scoreQuery)
//{
//    Console.Write(i + " ");
//}

namespace LINQ_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
        }
    }
}

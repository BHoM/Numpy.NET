/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Numpy;
using Python.Runtime;

namespace MatmulExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Efficient matrix multiplication with NumPy:");
            // before starting the measurement, let us call numpy once to get the setup checks done. 
            np.arange(1);
            var stopwatch = Stopwatch.StartNew();

            var a1 = np.arange(60000).reshape(300, 200);
            var a2 = np.arange(80000).reshape(200, 400);

            var result = np.matmul(a1, a2);
            stopwatch.Stop();

            Console.WriteLine($"execution time with NumPy: {stopwatch.Elapsed.TotalMilliseconds}ms\n");
            Console.WriteLine("Result:\n" + result.repr);


            Console.WriteLine("executing on bg thread");

            var a = np.arange(1000);
            var b = np.arange(1000);

            // https://github.com/pythonnet/pythonnet/issues/109
            PythonEngine.BeginAllowThreads();

            Task.Run(() =>
            {
                using (Py.GIL())
                {
                    np.matmul(a, b);
                    Console.WriteLine("matmul on bg thread is done");
                }
            }).Wait();
            Console.WriteLine("Press key");

            Console.ReadKey();
        }
    }
}

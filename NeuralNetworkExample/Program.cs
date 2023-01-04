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
using Numpy;

namespace NeuralNetworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fitting random data with a two layer Neural Network ...");
            // N is batch size; D_in is input dimension;
            // H is hidden dimension; D_out is output dimension.
            var (N, D_in, H, D_out) = (64, 1000, 100, 10);

            // Create random input and output data
            Console.WriteLine("\tcreating random data");
            var x = np.random.randn(N, D_in);
            var y = np.random.randn(N, D_out);

            Console.WriteLine("\tlearning");
            var stopwatch = Stopwatch.StartNew();
            // Randomly initialize weights
            var w1 = np.random.randn(D_in, H);
            var w2 = np.random.randn(H, D_out);

            var learning_rate = 1.0e-6;
            double loss=double.MaxValue;
            for (int t = 0; t < 500; t++)
            {
                // Forward pass: compute predicted y
                var h = x.dot(w1);
                var h_relu = np.maximum(h, (NDarray)0);
                var y_pred = h_relu.dot(w2);

                // Compute and print loss
                loss = (double)(np.square(y_pred - y).sum());
                if (t%20==0)
                    Console.WriteLine($"\tstep: {t} loss: {loss}");

                // Backprop to compute gradients of w1 and w2 with respect to loss
                var grad_y_pred = 2.0 * (y_pred - y);
                var grad_w2 = h_relu.T.dot(grad_y_pred);
                var grad_h_relu = grad_y_pred.dot(w2.T);
                var grad_h = grad_h_relu.copy();
                grad_h[h < 0] = (NDarray)0;
                var grad_w1 = x.T.dot(grad_h);

                // Update weights
                w1.isub( learning_rate * grad_w1); // inplace substraction is faster than -= 
                w2.isub( learning_rate * grad_w2);
            }
            stopwatch.Stop();
            Console.WriteLine($"\tstep: 500, final loss: {loss}, elapsed time: {stopwatch.Elapsed.TotalSeconds:F3} seconds\n");
            Console.WriteLine("Hit any key to exit.");
            Console.ReadKey();
        }
    }
}

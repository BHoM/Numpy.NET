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
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Numpy
{
    public partial class NDarray
    {
        public static implicit operator NDarray(Array array)
        {
            if (array == null)
                return null;
            switch (array)
            {
                case byte[] a: return np.array(a);
                case bool[] a: return np.array(a);
                case short[] a: return np.array(a);
                case int[] a: return np.array(a);
                case long[] a: return np.array(a);
                case float[] a: return np.array(a);
                case double[] a: return np.array(a);
                case byte[,] a: return np.array(a);
                case bool[,] a: return np.array(a);
                case short[,] a: return np.array(a);
                case int[,] a: return np.array(a);
                case long[,] a: return np.array(a);
                case float[,] a: return np.array(a);
                case double[,] a: return np.array(a);
                case byte[,,] a: return np.array(a);
                case bool[,,] a: return np.array(a);
                case short[,,] a: return np.array(a);
                case int[,,] a: return np.array(a);
                case long[,,] a: return np.array(a);
                case float[,,] a: return np.array(a);
                case double[,,] a: return np.array(a);
            }
            throw new InvalidOperationException($"Unable to cast {array.GetType()} to NDarray");
        }

        // these must be explicit or we have bad side effects
        public static explicit operator NDarray(bool d) => np.asarray(d);
        public static explicit operator NDarray(byte d) => np.asarray(d);
        public static explicit operator NDarray(short d) => np.asarray(d);
        public static explicit operator NDarray(int d) => np.asarray(d);
        public static explicit operator NDarray(long d) => np.asarray(d);
        public static explicit operator NDarray(float d) => np.asarray(d);
        public static explicit operator NDarray(double d) => np.asarray(d);

        // these must be explicit or we have bad side effects
        public static explicit operator bool(NDarray a) => np.asscalar<bool>(a);
        public static explicit operator byte(NDarray a) => np.asscalar<byte>(a);
        public static explicit operator short(NDarray a) => np.asscalar<short>(a);
        public static explicit operator int(NDarray a) => np.asscalar<int>(a);
        public static explicit operator long(NDarray a) => np.asscalar<long>(a);
        public static explicit operator float(NDarray a) => np.asscalar<float>(a);
        public static explicit operator double(NDarray a) => np.asscalar<double>(a);



    }
}

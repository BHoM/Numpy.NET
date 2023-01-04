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
using System.Net.Mail;
using System.Text;
using Python.Runtime;

namespace Numpy
{

    public partial class Dtype : PythonObject
    {
        public Dtype(PyObject pyobj) : base(pyobj)
        {
        }

        public Dtype(Dtype t) : base((PyObject)t.PyObject)
        {
        }

    }


    public static class DtypeExtensions
    {
        public static Dtype GetDtype<T>(this T obj)
        {
            return ToDtype(typeof(T));
        }

        public static Dtype GetDtype<T>(this T[] obj)
        {
            return ToDtype(typeof(T));
        }

        public static Dtype GetDtype(this object obj)
        {
            switch (obj as dynamic)
            {
                case bool o: return np.bool8;
                case sbyte o: return np.int8;
                case byte o: return np.uint8;
                case short o: return np.int16;
                case ushort o: return np.uint16;
                case int o: return np.int32;
                case uint o: return np.uint32;
                case long o: return np.int64;
                case ulong o: return np.uint64;
                case float o: return np.float32;
                case double o: return np.float64;
                case string o: return np.unicode_;
                case char o: return np.unicode_;
                case bool[] o: return np.bool8;
                case byte[] o: return np.@byte;
                case short[] o: return np.int16;
                case int[] o: return np.int32;
                case long[] o: return np.int64;
                case float[] o: return np.float32;
                case double[] o: return np.float64;
                case string[] o: return np.unicode_;
                case char[] o: return np.unicode_;
                case bool[,] o: return np.bool8;
                case byte[,] o: return np.uint8;
                case short[,] o: return np.int16;
                case int[,] o: return np.int32;
                case long[,] o: return np.int64;
                case float[,] o: return np.float32;
                case double[,] o: return np.float64;
                case string[,] o: return np.unicode_;
                case char[,] o: return np.unicode_;
                case bool[,,] o: return np.bool8;
                case byte[,,] o: return np.uint8;
                case short[,,] o: return np.int16;
                case int[,,] o: return np.int32;
                case long[,,] o: return np.int64;
                case float[,,] o: return np.float32;
                case double[,,] o: return np.float64;
                case string[,,] o: return np.unicode_;
                case char[,,] o: return np.unicode_;
                default: throw new ArgumentException($"Can not cast {obj.GetType()} to any dtype: ");
            }
        }

        public static Dtype ToDtype(this Type t)
        {
            object instance = Activator.CreateInstance(t);
            return GetDtype(instance);
        }
    }
}

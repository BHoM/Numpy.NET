/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2024, the respective contributors. All rights reserved.
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
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Numpy.Models;
using Python.Runtime;

namespace Numpy
{

    public static partial class np
    {

        /// <summary>
        /// Create an array.
        /// 
        /// <param name="data">
        /// The array to initialize the ndarray with
        /// </param>
        /// <returns>
        /// An array object satisfying the specified requirements.
        /// </returns>
        public static NDarray<T> array<T>(params T[] data) where T : struct
        {
            return array(data, dtype: null);
        }

        public static NDarray array(NDarray @object, Dtype dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
        {
            var args = ToTuple(new object[]
            {
                @object,
            });
            var kwargs = new PyDict();
            if (dtype != null) kwargs["dtype"] = ToPython(dtype);
            if (copy != null) kwargs["copy"] = ToPython(copy);
            if (order != null) kwargs["order"] = ToPython(order);
            if (subok != null) kwargs["subok"] = ToPython(subok);
            if (ndmin != null) kwargs["ndmin"] = ToPython(ndmin);
            dynamic py = self.InvokeMethod("array", args, kwargs);
            return ToCsharp<NDarray>(py);
        }

        public static NDarray<T> array<T>(T[] @object, Dtype dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
        {
            var type = @object.GetDtype();
            var ndarray = np.empty(new Shape(@object.Length), dtype: dtype ?? type, order: order); // todo: check out the other parameters
            if (@object.Length == 0)
                return new NDarray<T>(ndarray);
            long ptr = ndarray.PyObject.ctypes.data;
            switch ((object)@object)
            {
                case char[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case byte[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case short[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case int[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case long[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case float[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case double[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case bool[] a:
                    var bytes = a.Select(x => (byte)(x ? 1 : 0)).ToArray();
                    Marshal.Copy(bytes, 0, new IntPtr(ptr), a.Length);
                    break;
            }
            return new NDarray<T>(ndarray);
        }

        public static NDarray<T> array<T>(T[,] @object, Dtype dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
        {
            var d1_array = @object.Cast<T>().ToArray();
            var type = d1_array.GetDtype();
            var ndarray = np.empty(new Shape(@object.GetLength(0), @object.GetLength(1)), dtype: dtype ?? type, order: order); // todo: check out the other parameters
            if (@object.Length == 0)
                return new NDarray<T>(ndarray);
            long ptr = ndarray.PyObject.ctypes.data;
            switch ((object)d1_array)
            {
                case char[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case byte[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case short[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case int[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case long[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case float[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case double[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case bool[] a:
                    var bytes = a.Select(x => (byte)(x ? 1 : 0)).ToArray();
                    Marshal.Copy(bytes, 0, new IntPtr(ptr), a.Length);
                    break;
            }
            return new NDarray<T>(ndarray);
        }

        public static NDarray<T> array<T>(T[,,] data, Dtype dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
        {
            var d1_array = data.Cast<T>().ToArray();
            var type = d1_array.GetDtype();
            var ndarray = np.empty(new Shape(data.GetLength(0), data.GetLength(1), data.GetLength(2)), dtype: dtype ?? type, order: order); // todo: check out the other parameters
            if (data.Length == 0)
                return new NDarray<T>(ndarray);
            long ptr = ndarray.PyObject.ctypes.data;
            switch ((object)d1_array)
            {
                case char[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case byte[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case short[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case int[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case long[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case float[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case double[] a: Marshal.Copy(a, 0, new IntPtr(ptr), a.Length); break;
                case bool[] a:
                    var bytes = a.Select(x => (byte)(x ? 1 : 0)).ToArray();
                    Marshal.Copy(bytes, 0, new IntPtr(ptr), a.Length);
                    break;
            }
            return new NDarray<T>(ndarray);
        }

        public static NDarray array(string[] obj, int? itemsize = null, bool? copy = null, bool? unicode = null, string order = null)
        {
            var args = ToTuple(obj);
            var kwargs = new PyDict();
            if (itemsize != null) kwargs["itemsize"] = ToPython(itemsize);
            if (copy != null) kwargs["copy"] = ToPython(copy);
            if (unicode != null) kwargs["unicode"] = ToPython(unicode);
            if (order != null) kwargs["order"] = ToPython(order);
            dynamic py = self.InvokeMethod("array", args, kwargs);
            return ToCsharp<NDarray>(py);
        }

        public static NDarray array(List<NDarray> arrays, Dtype dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
            => array((IEnumerable<NDarray>)arrays, dtype, copy, order, subok, ndmin);

        public static NDarray array(NDarray[] arrays, Dtype dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
            => array((IEnumerable<NDarray>)arrays, dtype, copy, order, subok, ndmin);

        public static NDarray array(IEnumerable<NDarray> arrays, Dtype dtype = null, bool? copy = null, string order = null, bool? subok = null, int? ndmin = null)
        {
            var args = new PyTuple(new PyObject[] { new PyList(arrays.Select(nd => nd.PyObject as PyObject).ToArray()) });
            var kwargs = new PyDict();
            if (dtype != null) kwargs["dtype"] = ToPython(dtype);
            if (copy != null) kwargs["copy"] = ToPython(copy);
            if (order != null) kwargs["order"] = ToPython(order);
            if (subok != true) kwargs["subok"] = ToPython(subok);
            if (ndmin != null) kwargs["ndmin"] = ToPython(ndmin);
            dynamic py = self.InvokeMethod("array", args, kwargs);
            //dynamic py = dynamic_self.array(arrays, dtype, copy, order, subok, ndmin);
            return ToCsharp<NDarray>(py);
        }

        public static NDarray asarray(ValueType scalar, Dtype dtype = null)
        {
            var __self__ = self;
            var pyargs = ToTuple(new object[]
            {
                scalar,
            });
            var kwargs = new PyDict();
            if (dtype != null) kwargs["dtype"] = ToPython(dtype);
            dynamic py = __self__.InvokeMethod("asarray", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }

        /// <summary>
        /// Convert an array of size 1 to its scalar equivalent.
        /// </summary>
        /// <returns>
        /// Scalar representation of a. The output data type is the same type
        /// returned by the input’s item method.
        /// </returns>
        public static T asscalar<T>(NDarray a) => self.InvokeMethod("asscalar", a.PyObject).As<T>();

    }
}


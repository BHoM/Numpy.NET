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
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Numpy;
using Numpy.Models;
using Python.Runtime;

namespace Numpy
{

    public static partial class np
    {
        public static partial class random
        {
            /// <summary>
            ///	Random values in a given shape.<br></br>
            ///	
            ///	Create an array of the given shape and populate it with
            ///	random samples from a uniform distribution
            ///	over [0, 1).<br></br>
            ///	
            ///	Notes
            ///	
            ///	This is a convenience function.<br></br>
            ///	 If you want an interface that
            ///	takes a shape-tuple as the first argument, refer to
            ///	np.random.random_sample .
            /// </summary>
            /// <returns>
            ///	Random values.
            /// </returns>
            public static NDarray rand(params int[] shape)
            {
                //auto-generated code, do not change
                var random = self.GetAttr("random");
                var __self__ = random;
                var pyargs = ToTuple(shape);
                var kwargs = new PyDict();
                dynamic py = __self__.InvokeMethod("rand", pyargs, kwargs);
                return ToCsharp<NDarray>(py);
            }

            /// <summary>
            ///	Return a sample (or samples) from the “standard normal” distribution.<br></br>
            ///	
            ///	If positive, int_like or int-convertible arguments are provided,
            ///	randn generates an array of shape (d0, d1, ..., dn), filled
            ///	with random floats sampled from a univariate “normal” (Gaussian)
            ///	distribution of mean 0 and variance 1 (if any of the  are
            ///	floats, they are first converted to integers by truncation).<br></br>
            ///	 A single
            ///	float randomly sampled from the distribution is returned if no
            ///	argument is provided.<br></br>
            ///	
            ///	This is a convenience function.<br></br>
            ///	  If you want an interface that takes a
            ///	tuple as the first argument, use numpy.random.standard_normal instead.<br></br>
            ///	
            ///	Notes
            ///	
            ///	For random samples from , use:
            ///	
            ///	sigma * np.random.randn(...) + mu
            /// </summary>
            /// <returns>
            ///	A (d0, d1, ..., dn)-shaped array of floating-point samples from
            ///	the standard normal distribution, or a single such float if
            ///	no parameters were supplied.
            /// </returns>
            public static NDarray randn(params int[] shape)
            {
                //auto-generated code, do not change
                var random = self.GetAttr("random");
                var __self__ = random;
                var pyargs = ToTuple(shape);
                var kwargs = new PyDict();
                dynamic py = __self__.InvokeMethod("randn", pyargs, kwargs);
                return ToCsharp<NDarray>(py);
            }
        }
    }
}

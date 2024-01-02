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
using Numpy;
using Numpy.Models;
using Python.Runtime;

namespace Numpy
{
    /// <summary>
    /// Manual type conversions
    /// </summary>
    public static partial class np
    {

        /// <summary>
        ///	Join a sequence of arrays along an existing axis.<br></br>
        ///	
        ///	Notes
        ///	
        ///	When one or more of the arrays to be concatenated is a MaskedArray,
        ///	this function will return a MaskedArray object instead of an ndarray,
        ///	but the input masks are not preserved.<br></br>
        ///	 In cases where a MaskedArray
        ///	is expected as input, use the ma.concatenate function from the masked
        ///	array module instead.
        /// </summary>
        /// <param name="arys">
        ///	The arrays must have the same shape, except in the dimension
        ///	corresponding to axis (the first, by default).
        /// </param>
        /// <param name="axis">
        ///	The axis along which the arrays will be joined.<br></br>
        ///	If axis is None,
        ///	arrays are flattened before use.<br></br>
        ///	Default is 0.
        /// </param>
        /// <param name="out">
        ///	If provided, the destination to place the result.<br></br>
        ///	The shape must be
        ///	correct, matching that of what concatenate would have returned if no
        ///	out argument were specified.
        /// </param>
        /// <returns>
        ///	The concatenated array.
        /// </returns>
        public static NDarray concatenate((NDarray,NDarray) arys, int? axis = 0, NDarray @out = null)
            => concatenate(new []{arys.Item1, arys.Item2 }, axis, @out);

        /// <summary>
        ///	Join a sequence of arrays along an existing axis.<br></br>
        ///	
        ///	Notes
        ///	
        ///	When one or more of the arrays to be concatenated is a MaskedArray,
        ///	this function will return a MaskedArray object instead of an ndarray,
        ///	but the input masks are not preserved.<br></br>
        ///	 In cases where a MaskedArray
        ///	is expected as input, use the ma.concatenate function from the masked
        ///	array module instead.
        /// </summary>
        /// <param name="arys">
        ///	The arrays must have the same shape, except in the dimension
        ///	corresponding to axis (the first, by default).
        /// </param>
        /// <param name="axis">
        ///	The axis along which the arrays will be joined.<br></br>
        ///	If axis is None,
        ///	arrays are flattened before use.<br></br>
        ///	Default is 0.
        /// </param>
        /// <param name="out">
        ///	If provided, the destination to place the result.<br></br>
        ///	The shape must be
        ///	correct, matching that of what concatenate would have returned if no
        ///	out argument were specified.
        /// </param>
        /// <returns>
        ///	The concatenated array.
        /// </returns>
        public static NDarray concatenate((NDarray, NDarray, NDarray) arys, int? axis = 0, NDarray @out = null)
            => concatenate(new[] { arys.Item1, arys.Item2, arys.Item3 }, axis, @out);

        /// <summary>
        ///	Join a sequence of arrays along an existing axis.<br></br>
        ///	
        ///	Notes
        ///	
        ///	When one or more of the arrays to be concatenated is a MaskedArray,
        ///	this function will return a MaskedArray object instead of an ndarray,
        ///	but the input masks are not preserved.<br></br>
        ///	 In cases where a MaskedArray
        ///	is expected as input, use the ma.concatenate function from the masked
        ///	array module instead.
        /// </summary>
        /// <param name="arys">
        ///	The arrays must have the same shape, except in the dimension
        ///	corresponding to axis (the first, by default).
        /// </param>
        /// <param name="axis">
        ///	The axis along which the arrays will be joined.<br></br>
        ///	If axis is None,
        ///	arrays are flattened before use.<br></br>
        ///	Default is 0.
        /// </param>
        /// <param name="out">
        ///	If provided, the destination to place the result.<br></br>
        ///	The shape must be
        ///	correct, matching that of what concatenate would have returned if no
        ///	out argument were specified.
        /// </param>
        /// <returns>
        ///	The concatenated array.
        /// </returns>
        public static NDarray concatenate((NDarray, NDarray, NDarray, NDarray) arys, int? axis = 0, NDarray @out = null)
            => concatenate(new[] { arys.Item1, arys.Item2, arys.Item3, arys.Item4 }, axis, @out);

    }
}


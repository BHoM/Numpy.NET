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
        /// Return a new array with the specified shape.
        /// 
        /// If the new array is larger than the original array, then the new
        /// array is filled with repeated copies of a.  Note that this behavior
        /// is different from a.resize(new_shape) which fills with zeros instead
        /// of repeated copies of a.
        /// 
        /// Notes
        /// 
        /// Warning: This functionality does not consider axes separately,
        /// i.e. it does not apply interpolation/extrapolation.
        /// It fills the return array with the required number of elements, taken
        /// from a as they are laid out in memory, disregarding strides and axes.
        /// (This is in case the new shape is smaller. For larger, see above.)
        /// This functionality is therefore not suitable to resize images,
        /// or data where each axis represents a separate and distinct entity.
        /// </summary>
        /// <param name="a">
        /// Array to be resized.
        /// </param>
        /// <param name="new_shape">
        /// Shape of resized array.
        /// </param>
        /// <returns>
        /// The new array is formed from the data in the old array, repeated
        /// if necessary to fill out the required number of elements.  The
        /// data are repeated in the order that they are stored in memory.
        /// </returns>
        public static NDarray resize(NDarray a, Shape new_shape)
        {
            var pyargs = ToTuple(new object[]
            {
                a,
                new_shape,
            });
            dynamic py = self.InvokeMethod("resize", pyargs);
            return ToCsharp<NDarray>(py);
        }

    }
}


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
using System.Text;
using Python.Runtime;

namespace Numpy
{
    public static partial class np
    {
        /// <summary>
        /// IEEE 754 floating point representation of (positive) infinity.
        /// </summary>
        public static float inf => np.self.GetAttr("inf").As<float>();

        /// <summary>
        /// IEEE 754 floating point representation of (positive) infinity.
        /// 
        /// Use np.inf because Inf, Infinity, PINF and infty are aliases for inf.For more details, see inf.
        /// </summary>
        public static float Inf => np.self.GetAttr("inf").As<float>();

        /// <summary>
        /// IEEE 754 floating point representation of (positive) infinity.
        /// 
        /// Use np.inf because Inf, Infinity, PINF and infty are aliases for inf.For more details, see inf.
        /// </summary>
        public static float Infinity => np.self.GetAttr("inf").As<float>();

        /// <summary>
        /// IEEE 754 floating point representation of (positive) infinity.
        /// 
        /// Use np.inf because Inf, Infinity, PINF and infty are aliases for inf.For more details, see inf.
        /// </summary>
        public static float PINF => np.self.GetAttr("inf").As<float>();

        /// <summary>
        /// IEEE 754 floating point representation of (positive) infinity.
        /// 
        /// Use np.inf because Inf, Infinity, PINF and infty are aliases for inf.For more details, see inf.
        /// </summary>
        public static float infty => np.self.GetAttr("inf").As<float>();

        /// <summary>
        /// IEEE 754 floating point representation of (positive) infinity.
        /// </summary>
        public static float NINF => np.self.GetAttr("NINF").As<float>();

        /// <summary>
        /// IEEE 754 floating point representation of Not a Number(NaN).
        /// </summary>
        public static float nan => np.self.GetAttr("nan").As<float>();

        /// <summary>
        /// IEEE 754 floating point representation of Not a Number(NaN).
        /// 
        /// NaN and NAN are equivalent definitions of nan.Please use nan instead of NAN.
        /// </summary>
        public static float NaN => np.self.GetAttr("nan").As<float>();

        /// <summary>
        /// IEEE 754 floating point representation of Not a Number(NaN).
        /// 
        /// NaN and NAN are equivalent definitions of nan.Please use nan instead of NAN.
        /// </summary>
        public static float NAN => np.self.GetAttr("nan").As<float>();

        /// <summary>
        /// IEEE 754 floating point representation of negative zero.
        /// </summary>
        public static float NZERO => np.self.GetAttr("NZERO").As<float>();

        /// <summary>
        /// IEEE 754 floating point representation of positive zero.
        /// </summary>
        public static float PZERO => np.self.GetAttr("PZERO").As<float>();

        /// <summary>
        /// Euler’s constant, base of natural logarithms, Napier’s constant.
        /// </summary>
        public static float e => np.self.GetAttr("e").As<float>();

        /// <summary>
        /// γ = 0.5772156649015328606065120900824024310421...
        /// https://en.wikipedia.org/wiki/Euler-Mascheroni_constant
        /// </summary>
        public static float euler_gamma => np.self.GetAttr("e").As<float>();

        /// <summary>
        /// A convenient alias for None, useful for indexing arrays.
        /// </summary>
        public static object newaxis => np.self.GetAttr("newaxis");

        /// <summary>
        /// pi = 3.1415926535897932384626433...
        /// </summary>
        public static float pi => np.self.GetAttr("pi").As<float>();

    }
}

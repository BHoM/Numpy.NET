/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2019, the respective contributors. All rights reserved.
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

using System.Collections.Generic;
using System.Linq;
using np = Numpy;

namespace BH.Engine.Numpy
{
    public static partial class Convert
    {
        /***************************************************/
        /**** Public Methods                            ****/
        /***************************************************/

        public static np.NDarray<float> ToNumpy<T>(this List<T> list)
        {
            return np.np.array<float>(list.Cast<float>().ToArray<float>());
        }

        /***************************************************/

        public static np.NDarray<float> ToNumpy(this List<float> list)
        {
            return np.np.array<float>(list.ToArray());
        }

        /***************************************************/

        public static np.NDarray<double> ToNumpy(this List<double> list)
        {
            return np.np.array<double>(list.ToArray());
        }

        /***************************************************/

        public static np.NDarray<decimal> ToNumpy(this List<decimal> list)
        {
            return np.np.array<decimal>(list.ToArray());
        }

        /***************************************************/

        public static np.NDarray<int> ToNumpy(this List<int> list)
        {
            return np.np.array<int>(list.ToArray());
        }

        /***************************************************/

        public static np.NDarray<long> ToNumpy(this List<long> list)
        {
            return np.np.array<long>(list.ToArray());
        }

        /***************************************************/
    }
}

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

// Copyright (c) 2019 by the SciSharp Team
// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy.Models;

namespace Numpy
{
    public static partial class np
    {
        
        /// <summary>
        ///	Return the Bartlett window.<br></br>
        ///	
        ///	The Bartlett window is very similar to a triangular window, except
        ///	that the end points are at zero.<br></br>
        ///	  It is often used in signal
        ///	processing for tapering a signal, without generating too much
        ///	ripple in the frequency domain.<br></br>
        ///	
        ///	Notes
        ///	
        ///	The Bartlett window is defined as
        ///	
        ///	Most references to the Bartlett window come from the signal
        ///	processing literature, where it is used as one of many windowing
        ///	functions for smoothing values.<br></br>
        ///	  Note that convolution with this
        ///	window produces linear interpolation.<br></br>
        ///	  It is also known as an
        ///	apodization (which means”removing the foot”, i.e.<br></br>
        ///	 smoothing
        ///	discontinuities at the beginning and end of the sampled signal) or
        ///	tapering function.<br></br>
        ///	 The fourier transform of the Bartlett is the product
        ///	of two sinc functions.<br></br>
        ///	
        ///	Note the excellent discussion in Kanasewich.<br></br>
        ///	
        ///	References
        /// </summary>
        /// <param name="M">
        ///	Number of points in the output window.<br></br>
        ///	If zero or less, an
        ///	empty array is returned.
        /// </param>
        /// <returns>
        ///	The triangular window, with the maximum value normalized to one
        ///	(the value one appears only if the number of samples is odd), with
        ///	the first and last samples equal to zero.
        /// </returns>
        public static NDarray bartlett(int M)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                M,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("bartlett", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        ///	Return the Blackman window.<br></br>
        ///	
        ///	The Blackman window is a taper formed by using the first three
        ///	terms of a summation of cosines.<br></br>
        ///	 It was designed to have close to the
        ///	minimal leakage possible.<br></br>
        ///	  It is close to optimal, only slightly worse
        ///	than a Kaiser window.<br></br>
        ///	
        ///	Notes
        ///	
        ///	The Blackman window is defined as
        ///	
        ///	Most references to the Blackman window come from the signal processing
        ///	literature, where it is used as one of many windowing functions for
        ///	smoothing values.<br></br>
        ///	  It is also known as an apodization (which means
        ///	“removing the foot”, i.e.<br></br>
        ///	 smoothing discontinuities at the beginning
        ///	and end of the sampled signal) or tapering function.<br></br>
        ///	 It is known as a
        ///	“near optimal” tapering function, almost as good (by some measures)
        ///	as the kaiser window.<br></br>
        ///	
        ///	References
        ///	
        ///	Blackman, R.B.<br></br>
        ///	 and Tukey, J.W., (1958) The measurement of power spectra,
        ///	Dover Publications, New York.<br></br>
        ///	
        ///	Oppenheim, A.V., and R.W.<br></br>
        ///	 Schafer.<br></br>
        ///	 Discrete-Time Signal Processing.<br></br>
        ///	
        ///	Upper Saddle River, NJ: Prentice-Hall, 1999, pp.<br></br>
        ///	 468-471.
        /// </summary>
        /// <param name="M">
        ///	Number of points in the output window.<br></br>
        ///	If zero or less, an empty
        ///	array is returned.
        /// </param>
        /// <returns>
        ///	The window, with the maximum value normalized to one (the value one
        ///	appears only if the number of samples is odd).
        /// </returns>
        public static NDarray blackman(int M)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                M,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("blackman", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        ///	Return the Hamming window.<br></br>
        ///	
        ///	The Hamming window is a taper formed by using a weighted cosine.<br></br>
        ///	
        ///	Notes
        ///	
        ///	The Hamming window is defined as
        ///	
        ///	The Hamming was named for R.<br></br>
        ///	 W.<br></br>
        ///	 Hamming, an associate of J.<br></br>
        ///	 W.<br></br>
        ///	 Tukey
        ///	and is described in Blackman and Tukey.<br></br>
        ///	 It was recommended for
        ///	smoothing the truncated autocovariance function in the time domain.<br></br>
        ///	
        ///	Most references to the Hamming window come from the signal processing
        ///	literature, where it is used as one of many windowing functions for
        ///	smoothing values.<br></br>
        ///	  It is also known as an apodization (which means
        ///	“removing the foot”, i.e.<br></br>
        ///	 smoothing discontinuities at the beginning
        ///	and end of the sampled signal) or tapering function.<br></br>
        ///	
        ///	References
        /// </summary>
        /// <param name="M">
        ///	Number of points in the output window.<br></br>
        ///	If zero or less, an
        ///	empty array is returned.
        /// </param>
        /// <returns>
        ///	The window, with the maximum value normalized to one (the value
        ///	one appears only if the number of samples is odd).
        /// </returns>
        public static NDarray hamming(int M)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                M,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("hamming", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        ///	Return the Hanning window.<br></br>
        ///	
        ///	The Hanning window is a taper formed by using a weighted cosine.<br></br>
        ///	
        ///	Notes
        ///	
        ///	The Hanning window is defined as
        ///	
        ///	The Hanning was named for Julius von Hann, an Austrian meteorologist.<br></br>
        ///	
        ///	It is also known as the Cosine Bell.<br></br>
        ///	 Some authors prefer that it be
        ///	called a Hann window, to help avoid confusion with the very similar
        ///	Hamming window.<br></br>
        ///	
        ///	Most references to the Hanning window come from the signal processing
        ///	literature, where it is used as one of many windowing functions for
        ///	smoothing values.<br></br>
        ///	  It is also known as an apodization (which means
        ///	“removing the foot”, i.e.<br></br>
        ///	 smoothing discontinuities at the beginning
        ///	and end of the sampled signal) or tapering function.<br></br>
        ///	
        ///	References
        /// </summary>
        /// <param name="M">
        ///	Number of points in the output window.<br></br>
        ///	If zero or less, an
        ///	empty array is returned.
        /// </param>
        /// <returns>
        ///	The window, with the maximum value normalized to one (the value
        ///	one appears only if M is odd).
        /// </returns>
        public static NDarray hanning(int M)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                M,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("hanning", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        ///	Return the Kaiser window.<br></br>
        ///	
        ///	The Kaiser window is a taper formed by using a Bessel function.<br></br>
        ///	
        ///	Notes
        ///	
        ///	The Kaiser window is defined as
        ///	
        ///	with
        ///	
        ///	where  is the modified zeroth-order Bessel function.<br></br>
        ///	
        ///	The Kaiser was named for Jim Kaiser, who discovered a simple
        ///	approximation to the DPSS window based on Bessel functions.<br></br>
        ///	  The Kaiser
        ///	window is a very good approximation to the Digital Prolate Spheroidal
        ///	Sequence, or Slepian window, which is the transform which maximizes the
        ///	energy in the main lobe of the window relative to total energy.<br></br>
        ///	
        ///	The Kaiser can approximate many other windows by varying the beta
        ///	parameter.<br></br>
        ///	
        ///	A beta value of 14 is probably a good starting point.<br></br>
        ///	 Note that as beta
        ///	gets large, the window narrows, and so the number of samples needs to be
        ///	large enough to sample the increasingly narrow spike, otherwise NaNs will
        ///	get returned.<br></br>
        ///	
        ///	Most references to the Kaiser window come from the signal processing
        ///	literature, where it is used as one of many windowing functions for
        ///	smoothing values.<br></br>
        ///	  It is also known as an apodization (which means
        ///	“removing the foot”, i.e.<br></br>
        ///	 smoothing discontinuities at the beginning
        ///	and end of the sampled signal) or tapering function.<br></br>
        ///	
        ///	References
        /// </summary>
        /// <param name="M">
        ///	Number of points in the output window.<br></br>
        ///	If zero or less, an
        ///	empty array is returned.
        /// </param>
        /// <param name="beta">
        ///	Shape parameter for window.
        /// </param>
        /// <returns>
        ///	The window, with the maximum value normalized to one (the value
        ///	one appears only if the number of samples is odd).
        /// </returns>
        public static NDarray kaiser(int M, float beta)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                M,
                beta,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("kaiser", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        
    }
}


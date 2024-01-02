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
using Numpy.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace Numpy.UnitTest
{
    [TestClass]
    public class NumPy_dtype_routinesTest : BaseTestCase
    {
        
        [TestMethod]
        public void can_castTest()
        {
            // Basic examples
            
            // >>> np.can_cast(np.int32, np.int64)
            // True
            // >>> np.can_cast(np.float64, complex)
            // True
            // >>> np.can_cast(complex, float)
            // False
            // 
            
            #if TODO
            var given=  np.can_cast(np.int32, np.int64);
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.can_cast(np.float64, complex);
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.can_cast(complex, float);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.can_cast('i8', 'f8')
            // True
            // >>> np.can_cast('i8', 'f4')
            // False
            // >>> np.can_cast('i4', 'S4')
            // False
            // 
            
            #if TODO
             given=  np.can_cast('i8', 'f8');
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.can_cast('i8', 'f4');
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.can_cast('i4', 'S4');
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Casting scalars
            
            // >>> np.can_cast(100, 'i1')
            // True
            // >>> np.can_cast(150, 'i1')
            // False
            // >>> np.can_cast(150, 'u1')
            // True
            // 
            
            #if TODO
             given=  np.can_cast(100, 'i1');
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.can_cast(150, 'i1');
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.can_cast(150, 'u1');
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.can_cast(3.5e100, np.float32)
            // False
            // >>> np.can_cast(1000.0, np.float32)
            // True
            // 
            
            #if TODO
             given=  np.can_cast(3.5e100, np.float32);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.can_cast(1000.0, np.float32);
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Array scalar checks the value, array does not
            
            // >>> np.can_cast(np.array(1000.0), np.float32)
            // True
            // >>> np.can_cast(np.array([1000.0]), np.float32)
            // False
            // 
            
            #if TODO
             given=  np.can_cast(np.array(1000.0), np.float32);
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.can_cast(np.array({1000.0}), np.float32);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Using the casting rules
            
            // >>> np.can_cast('i8', 'i8', 'no')
            // True
            // >>> np.can_cast('<i8', '>i8', 'no')
            // False
            // 
            
            #if TODO
             given=  np.can_cast('i8', 'i8', 'no');
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.can_cast('<i8', '>i8', 'no');
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.can_cast('<i8', '>i8', 'equiv')
            // True
            // >>> np.can_cast('<i4', '>i8', 'equiv')
            // False
            // 
            
            #if TODO
             given=  np.can_cast('<i8', '>i8', 'equiv');
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.can_cast('<i4', '>i8', 'equiv');
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.can_cast('<i4', '>i8', 'safe')
            // True
            // >>> np.can_cast('<i8', '>i4', 'safe')
            // False
            // 
            
            #if TODO
             given=  np.can_cast('<i4', '>i8', 'safe');
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.can_cast('<i8', '>i4', 'safe');
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.can_cast('<i8', '>i4', 'same_kind')
            // True
            // >>> np.can_cast('<i8', '>u4', 'same_kind')
            // False
            // 
            
            #if TODO
             given=  np.can_cast('<i8', '>i4', 'same_kind');
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.can_cast('<i8', '>u4', 'same_kind');
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.can_cast('<i8', '>u4', 'unsafe')
            // True
            // 
            
            #if TODO
             given=  np.can_cast('<i8', '>u4', 'unsafe');
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void promote_typesTest()
        {
            // >>> np.promote_types('f4', 'f8')
            // dtype('float64')
            // 
            
            #if TODO
            var given=  np.promote_types('f4', 'f8');
            var expected=
                "dtype('float64')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.promote_types('i8', 'f4')
            // dtype('float64')
            // 
            
            #if TODO
             given=  np.promote_types('i8', 'f4');
             expected=
                "dtype('float64')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.promote_types('>i8', '<c8')
            // dtype('complex128')
            // 
            
            #if TODO
             given=  np.promote_types('>i8', '<c8');
             expected=
                "dtype('complex128')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.promote_types('i4', 'S8')
            // dtype('S11')
            // 
            
            #if TODO
             given=  np.promote_types('i4', 'S8');
             expected=
                "dtype('S11')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // An example of a non-associative case:
            
            // >>> p = np.promote_types
            // >>> p('S', p('i1', 'u1'))
            // dtype('S6')
            // >>> p(p('S', 'i1'), 'u1')
            // dtype('S4')
            // 
            
            #if TODO
             given=  p = np.promote_types;
             given=  p('S', p('i1', 'u1'));
             expected=
                "dtype('S6')";
            Assert.AreEqual(expected, given.repr);
             given=  p(p('S', 'i1'), 'u1');
             expected=
                "dtype('S4')";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void min_scalar_typeTest()
        {
            // >>> np.min_scalar_type(10)
            // dtype('uint8')
            // 
            
            #if TODO
            var given=  np.min_scalar_type(10);
            var expected=
                "dtype('uint8')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.min_scalar_type(-260)
            // dtype('int16')
            // 
            
            #if TODO
             given=  np.min_scalar_type(-260);
             expected=
                "dtype('int16')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.min_scalar_type(3.1)
            // dtype('float16')
            // 
            
            #if TODO
             given=  np.min_scalar_type(3.1);
             expected=
                "dtype('float16')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.min_scalar_type(1e50)
            // dtype('float64')
            // 
            
            #if TODO
             given=  np.min_scalar_type(1e50);
             expected=
                "dtype('float64')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.min_scalar_type(np.arange(4,dtype='f8'))
            // dtype('float64')
            // 
            
            #if TODO
             given=  np.min_scalar_type(np.arange(4,dtype='f8'));
             expected=
                "dtype('float64')";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void result_typeTest()
        {
            // >>> np.result_type(3, np.arange(7, dtype='i1'))
            // dtype('int8')
            // 
            
            #if TODO
            var given=  np.result_type(3, np.arange(7, dtype='i1'));
            var expected=
                "dtype('int8')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.result_type('i4', 'c8')
            // dtype('complex128')
            // 
            
            #if TODO
             given=  np.result_type('i4', 'c8');
             expected=
                "dtype('complex128')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.result_type(3.0, -2)
            // dtype('float64')
            // 
            
            #if TODO
             given=  np.result_type(3.0, -2);
             expected=
                "dtype('float64')";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void common_typeTest()
        {
            // >>> np.common_type(np.arange(2, dtype=np.float32))
            // <type 'numpy.float32'>
            // >>> np.common_type(np.arange(2, dtype=np.float32), np.arange(2))
            // <type 'numpy.float64'>
            // >>> np.common_type(np.arange(4), np.array([45, 6.j]), np.array([45.0]))
            // <type 'numpy.complex128'>
            // 
            
            #if TODO
            var given=  np.common_type(np.arange(2, dtype=np.float32));
            var expected=
                "<type 'numpy.float32'>";
            Assert.AreEqual(expected, given.repr);
             given=  np.common_type(np.arange(2, dtype=np.float32), np.arange(2));
             expected=
                "<type 'numpy.float64'>";
            Assert.AreEqual(expected, given.repr);
             given=  np.common_type(np.arange(4), np.array({45, 6.j}), np.array({45.0}));
             expected=
                "<type 'numpy.complex128'>";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void obj2sctypeTest()
        {
            // >>> np.obj2sctype(np.int32)
            // <type 'numpy.int32'>
            // >>> np.obj2sctype(np.array([1., 2.]))
            // <type 'numpy.float64'>
            // >>> np.obj2sctype(np.array([1.j]))
            // <type 'numpy.complex128'>
            // 
            
            #if TODO
            var given=  np.obj2sctype(np.int32);
            var expected=
                "<type 'numpy.int32'>";
            Assert.AreEqual(expected, given.repr);
             given=  np.obj2sctype(np.array({1., 2.}));
             expected=
                "<type 'numpy.float64'>";
            Assert.AreEqual(expected, given.repr);
             given=  np.obj2sctype(np.array({1.j}));
             expected=
                "<type 'numpy.complex128'>";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.obj2sctype(dict)
            // <type 'numpy.object_'>
            // >>> np.obj2sctype('string')
            // <type 'numpy.string_'>
            // 
            
            #if TODO
             given=  np.obj2sctype(dict);
             expected=
                "<type 'numpy.object_'>";
            Assert.AreEqual(expected, given.repr);
             given=  np.obj2sctype('string');
             expected=
                "<type 'numpy.string_'>";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.obj2sctype(1, default=list)
            // <type 'list'>
            // 
            
            #if TODO
             given=  np.obj2sctype(1, default=list);
             expected=
                "<type 'list'>";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void dtypeTest()
        {
            // Using array-scalar type:
            
            // >>> np.dtype(np.int16)
            // dtype('int16')
            // 
            
            #if TODO
            var given=  np.dtype(np.int16);
            var expected=
                "dtype('int16')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Structured type, one field name ‘f1’, containing int16:
            
            // >>> np.dtype([('f1', np.int16)])
            // dtype([('f1', '<i2')])
            // 
            
            #if TODO
             given=  np.dtype({('f1', np.int16)});
             expected=
                "dtype([('f1', '<i2')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Structured type, one field named ‘f1’, in itself containing a structured
            // type with one field:
            
            // >>> np.dtype([('f1', [('f1', np.int16)])])
            // dtype([('f1', [('f1', '<i2')])])
            // 
            
            #if TODO
             given=  np.dtype({('f1', {('f1', np.int16)})});
             expected=
                "dtype([('f1', [('f1', '<i2')])])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Structured type, two fields: the first field contains an unsigned int, the
            // second an int32:
            
            // >>> np.dtype([('f1', np.uint), ('f2', np.int32)])
            // dtype([('f1', '<u4'), ('f2', '<i4')])
            // 
            
            #if TODO
             given=  np.dtype({('f1', np.uint), ('f2', np.int32)});
             expected=
                "dtype([('f1', '<u4'), ('f2', '<i4')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Using array-protocol type strings:
            
            // >>> np.dtype([('a','f8'),('b','S10')])
            // dtype([('a', '<f8'), ('b', '|S10')])
            // 
            
            #if TODO
             given=  np.dtype({('a','f8'),('b','S10')});
             expected=
                "dtype([('a', '<f8'), ('b', '|S10')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Using comma-separated field formats.  The shape is (2,3):
            
            // >>> np.dtype("i4, (2,3)f8")
            // dtype([('f0', '<i4'), ('f1', '<f8', (2, 3))])
            // 
            
            #if TODO
             given=  np.dtype("i4, (2,3)f8");
             expected=
                "dtype([('f0', '<i4'), ('f1', '<f8', (2, 3))])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Using tuples.  int is a fixed type, 3 the field’s shape.  void
            // is a flexible type, here of size 10:
            
            // >>> np.dtype([('hello',(int,3)),('world',np.void,10)])
            // dtype([('hello', '<i4', 3), ('world', '|V10')])
            // 
            
            #if TODO
             given=  np.dtype({('hello',(int,3)),('world',np.void,10)});
             expected=
                "dtype([('hello', '<i4', 3), ('world', '|V10')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Subdivide int16 into 2 int8’s, called x and y.  0 and 1 are
            // the offsets in bytes:
            
            // >>> np.dtype((np.int16, {'x':(np.int8,0), 'y':(np.int8,1)}))
            // dtype(('<i2', [('x', '|i1'), ('y', '|i1')]))
            // 
            
            #if TODO
             given=  np.dtype((np.int16, {'x':(np.int8,0), 'y':(np.int8,1)}));
             expected=
                "dtype(('<i2', [('x', '|i1'), ('y', '|i1')]))";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Using dictionaries.  Two fields named ‘gender’ and ‘age’:
            
            // >>> np.dtype({'names':['gender','age'], 'formats':['S1',np.uint8]})
            // dtype([('gender', '|S1'), ('age', '|u1')])
            // 
            
            #if TODO
             given=  np.dtype({'names':{'gender','age'}, 'formats':{'S1',np.uint8}});
             expected=
                "dtype([('gender', '|S1'), ('age', '|u1')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Offsets in bytes, here 0 and 25:
            
            // >>> np.dtype({'surname':('S25',0),'age':(np.uint8,25)})
            // dtype([('surname', '|S25'), ('age', '|u1')])
            // 
            
            #if TODO
             given=  np.dtype({'surname':('S25',0),'age':(np.uint8,25)});
             expected=
                "dtype([('surname', '|S25'), ('age', '|u1')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> dt = np.dtype('i2')
            // >>> dt.byteorder
            // '='
            // >>> # endian is not relevant for 8 bit numbers
            // >>> np.dtype('i1').byteorder
            // '|'
            // >>> # or ASCII strings
            // >>> np.dtype('S2').byteorder
            // '|'
            // >>> # Even if specific code is given, and it is native
            // >>> # '=' is the byteorder
            // >>> import sys
            // >>> sys_is_le = sys.byteorder == 'little'
            // >>> native_code = sys_is_le and '<' or '>'
            // >>> swapped_code = sys_is_le and '>' or '<'
            // >>> dt = np.dtype(native_code + 'i2')
            // >>> dt.byteorder
            // '='
            // >>> # Swapped code shows up as itself
            // >>> dt = np.dtype(swapped_code + 'i2')
            // >>> dt.byteorder == swapped_code
            // True
            // 
            
            #if TODO
             given=  dt = np.dtype('i2');
             given=  dt.byteorder;
             expected=
                "'='";
            Assert.AreEqual(expected, given.repr);
             given=  # endian is not relevant for 8 bit numbers;
             given=  np.dtype('i1').byteorder;
             expected=
                "'|'";
            Assert.AreEqual(expected, given.repr);
             given=  # or ASCII strings;
             given=  np.dtype('S2').byteorder;
             expected=
                "'|'";
            Assert.AreEqual(expected, given.repr);
             given=  # Even if specific code is given, and it is native;
             given=  # '=' is the byteorder;
             given=  import sys;
             given=  sys_is_le = sys.byteorder == 'little';
             given=  native_code = sys_is_le and '<' or '>';
             given=  swapped_code = sys_is_le and '>' or '<';
             given=  dt = np.dtype(native_code + 'i2');
             given=  dt.byteorder;
             expected=
                "'='";
            Assert.AreEqual(expected, given.repr);
             given=  # Swapped code shows up as itself;
             given=  dt = np.dtype(swapped_code + 'i2');
             given=  dt.byteorder == swapped_code;
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Methods
            
        }
        
        
        [TestMethod]
        public void format_parserTest()
        {
            // >>> np.format_parser(['f8', 'i4', 'a5'], ['col1', 'col2', 'col3'],
            // ...                  ['T1', 'T2', 'T3']).dtype
            // dtype([(('T1', 'col1'), '<f8'), (('T2', 'col2'), '<i4'),
            //        (('T3', 'col3'), '|S5')])
            // 
            
            #if TODO
            var given=  np.format_parser({'f8', 'i4', 'a5'}, {'col1', 'col2', 'col3'},;
            var expected=
                "...                  ['T1', 'T2', 'T3']).dtype\n" +
                "dtype([(('T1', 'col1'), '<f8'), (('T2', 'col2'), '<i4'),\n" +
                "       (('T3', 'col3'), '|S5')])";
            Assert.AreEqual(expected, given.repr);
            #endif
            // names and/or titles can be empty lists. If titles is an empty list,
            // titles will simply not appear. If names is empty, default field names
            // will be used.
            
            // >>> np.format_parser(['f8', 'i4', 'a5'], ['col1', 'col2', 'col3'],
            // ...                  []).dtype
            // dtype([('col1', '<f8'), ('col2', '<i4'), ('col3', '|S5')])
            // >>> np.format_parser(['f8', 'i4', 'a5'], [], []).dtype
            // dtype([('f0', '<f8'), ('f1', '<i4'), ('f2', '|S5')])
            // 
            
            #if TODO
             given=  np.format_parser({'f8', 'i4', 'a5'}, {'col1', 'col2', 'col3'},;
             expected=
                "...                  []).dtype\n" +
                "dtype([('col1', '<f8'), ('col2', '<i4'), ('col3', '|S5')])";
            Assert.AreEqual(expected, given.repr);
             given=  np.format_parser({'f8', 'i4', 'a5'}, {}, {}).dtype;
             expected=
                "dtype([('f0', '<f8'), ('f1', '<i4'), ('f2', '|S5')])";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void iinfoTest()
        {
            // With types:
            
            // >>> ii16 = np.iinfo(np.int16)
            // >>> ii16.min
            // -32768
            // >>> ii16.max
            // 32767
            // >>> ii32 = np.iinfo(np.int32)
            // >>> ii32.min
            // -2147483648
            // >>> ii32.max
            // 2147483647
            // 
            
            #if TODO
            var given=  ii16 = np.iinfo(np.int16);
             given=  ii16.min;
            var expected=
                "-32768";
            Assert.AreEqual(expected, given.repr);
             given=  ii16.max;
             expected=
                "32767";
            Assert.AreEqual(expected, given.repr);
             given=  ii32 = np.iinfo(np.int32);
             given=  ii32.min;
             expected=
                "-2147483648";
            Assert.AreEqual(expected, given.repr);
             given=  ii32.max;
             expected=
                "2147483647";
            Assert.AreEqual(expected, given.repr);
            #endif
            // With instances:
            
            // >>> ii32 = np.iinfo(np.int32(10))
            // >>> ii32.min
            // -2147483648
            // >>> ii32.max
            // 2147483647
            // 
            
            #if TODO
             given=  ii32 = np.iinfo(np.int32(10));
             given=  ii32.min;
             expected=
                "-2147483648";
            Assert.AreEqual(expected, given.repr);
             given=  ii32.max;
             expected=
                "2147483647";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void issctypeTest()
        {
            // >>> np.issctype(np.int32)
            // True
            // >>> np.issctype(list)
            // False
            // >>> np.issctype(1.1)
            // False
            // 
            
            #if TODO
            var given=  np.issctype(np.int32);
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.issctype(list);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
             given=  np.issctype(1.1);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Strings are also a scalar type:
            
            // >>> np.issctype(np.dtype('str'))
            // True
            // 
            
            #if TODO
             given=  np.issctype(np.dtype('str'));
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void issubdtypeTest()
        {
            // >>> np.issubdtype('S1', np.string_)
            // True
            // >>> np.issubdtype(np.float64, np.float32)
            // False
            // 
            
            #if TODO
            var given=  np.issubdtype('S1', np.string_);
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.issubdtype(np.float64, np.float32);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void issubsctypeTest()
        {
            // >>> np.issubsctype('S8', str)
            // True
            // >>> np.issubsctype(np.array([1]), int)
            // True
            // >>> np.issubsctype(np.array([1]), float)
            // False
            // 
            
            #if TODO
            var given=  np.issubsctype('S8', str);
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.issubsctype(np.array({1}), int);
             expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.issubsctype(np.array({1}), float);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void issubclass_Test()
        {
            // >>> np.issubclass_(np.int32, int)
            // True
            // >>> np.issubclass_(np.int32, float)
            // False
            // 
            
            #if TODO
            var given=  np.issubclass_(np.int32, int);
            var expected=
                "True";
            Assert.AreEqual(expected, given.repr);
             given=  np.issubclass_(np.int32, float);
             expected=
                "False";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void find_common_typeTest()
        {
            // >>> np.find_common_type([], [np.int64, np.float32, complex])
            // dtype('complex128')
            // >>> np.find_common_type([np.int64, np.float32], [])
            // dtype('float64')
            // 
            
            #if TODO
            var given=  np.find_common_type({}, {np.int64, np.float32, complex});
            var expected=
                "dtype('complex128')";
            Assert.AreEqual(expected, given.repr);
             given=  np.find_common_type({np.int64, np.float32}, {});
             expected=
                "dtype('float64')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // The standard casting rules ensure that a scalar cannot up-cast an
            // array unless the scalar is of a fundamentally different kind of data
            // (i.e. under a different hierarchy in the data type hierarchy) then
            // the array:
            
            // >>> np.find_common_type([np.float32], [np.int64, np.float64])
            // dtype('float32')
            // 
            
            #if TODO
             given=  np.find_common_type({np.float32}, {np.int64, np.float64});
             expected=
                "dtype('float32')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Complex is of a different type, so it up-casts the float in the
            // array_types argument:
            
            // >>> np.find_common_type([np.float32], [complex])
            // dtype('complex128')
            // 
            
            #if TODO
             given=  np.find_common_type({np.float32}, {complex});
             expected=
                "dtype('complex128')";
            Assert.AreEqual(expected, given.repr);
            #endif
            // Type specifier strings are convertible to dtypes and can therefore
            // be used instead of dtypes:
            
            // >>> np.find_common_type(['f4', 'f4', 'i4'], ['c8'])
            // dtype('complex128')
            // 
            
            #if TODO
             given=  np.find_common_type({'f4', 'f4', 'i4'}, {'c8'});
             expected=
                "dtype('complex128')";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void typenameTest()
        {
            // >>> typechars = ['S1', '?', 'B', 'D', 'G', 'F', 'I', 'H', 'L', 'O', 'Q',
            // ...              'S', 'U', 'V', 'b', 'd', 'g', 'f', 'i', 'h', 'l', 'q']
            // >>> for typechar in typechars:
            // ...     print(typechar, ' : ', np.typename(typechar))
            // ...
            // S1  :  character
            // ?  :  bool
            // B  :  unsigned char
            // D  :  complex double precision
            // G  :  complex long double precision
            // F  :  complex single precision
            // I  :  unsigned integer
            // H  :  unsigned short
            // L  :  unsigned long integer
            // O  :  object
            // Q  :  unsigned long long integer
            // S  :  string
            // U  :  unicode
            // V  :  void
            // b  :  signed char
            // d  :  double precision
            // g  :  long precision
            // f  :  single precision
            // i  :  integer
            // h  :  short
            // l  :  long integer
            // q  :  long long integer
            // 
            
            #if TODO
            var given=  typechars = ['S1', '?', 'B', 'D', 'G', 'F', 'I', 'H', 'L', 'O', 'Q',;
            var expected=
                "...              'S', 'U', 'V', 'b', 'd', 'g', 'f', 'i', 'h', 'l', 'q']";
            Assert.AreEqual(expected, given.repr);
             given=  for typechar in typechars:;
             expected=
                "...     print(typechar, ' : ', np.typename(typechar))\n" +
                "...\n" +
                "S1  :  character\n" +
                "?  :  bool\n" +
                "B  :  unsigned char\n" +
                "D  :  complex double precision\n" +
                "G  :  complex long double precision\n" +
                "F  :  complex single precision\n" +
                "I  :  unsigned integer\n" +
                "H  :  unsigned short\n" +
                "L  :  unsigned long integer\n" +
                "O  :  object\n" +
                "Q  :  unsigned long long integer\n" +
                "S  :  string\n" +
                "U  :  unicode\n" +
                "V  :  void\n" +
                "b  :  signed char\n" +
                "d  :  double precision\n" +
                "g  :  long precision\n" +
                "f  :  single precision\n" +
                "i  :  integer\n" +
                "h  :  short\n" +
                "l  :  long integer\n" +
                "q  :  long long integer";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void sctype2charTest()
        {
            // >>> for sctype in [np.int32, float, complex, np.string_, np.ndarray]:
            // ...     print(np.sctype2char(sctype))
            // l
            // d
            // D
            // S
            // O
            // 
            
            #if TODO
            var given=  for sctype in {np.int32, float, complex, np.string_, np.ndarray}:;
            var expected=
                "...     print(np.sctype2char(sctype))\n" +
                "l\n" +
                "d\n" +
                "D\n" +
                "S\n" +
                "O";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> x = np.array([1., 2-1.j])
            // >>> np.sctype2char(x)
            // 'D'
            // >>> np.sctype2char(list)
            // 'O'
            // 
            
            #if TODO
             given=  x = np.array({1., 2-1.j});
             given=  np.sctype2char(x);
             expected=
                "'D'";
            Assert.AreEqual(expected, given.repr);
             given=  np.sctype2char(list);
             expected=
                "'O'";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
        
        [TestMethod]
        public void mintypecodeTest()
        {
            // >>> np.mintypecode(['d', 'f', 'S'])
            // 'd'
            // >>> x = np.array([1.1, 2-3.j])
            // >>> np.mintypecode(x)
            // 'D'
            // 
            
            #if TODO
            var given=  np.mintypecode({'d', 'f', 'S'});
            var expected=
                "'d'";
            Assert.AreEqual(expected, given.repr);
             given=  x = np.array({1.1, 2-3.j});
             given=  np.mintypecode(x);
             expected=
                "'D'";
            Assert.AreEqual(expected, given.repr);
            #endif
            // >>> np.mintypecode('abceh', default='G')
            // 'G'
            // 
            
            #if TODO
             given=  np.mintypecode('abceh', default='G');
             expected=
                "'G'";
            Assert.AreEqual(expected, given.repr);
            #endif
        }
        
    }
}


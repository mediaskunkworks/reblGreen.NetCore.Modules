﻿/*
    The MIT License (MIT)

    Copyright (c) 2019 reblGreen Software Ltd. (https://reblgreen.com/)
    Repository Url: https://bitbucket.org/reblgreen/reblgreen.netcore.modules/

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.
 */

using System;
using System.IO;
using System.Reflection;

namespace reblGreen.NetCore.Modules.Classes
{
    [Serializable]
    internal static class AssemblyTools
    {
        /// <summary>
        /// Fetch info form the Assembly which contains the Type. This can be used to get the Assembly name and version, etc...
        /// </summary>
        public static AssemblyName GetAssemblyInfo<T>() where T : Type
        {
            return GetAssemblyInfo(typeof(T));
        }


        /// <summary>
        /// Fetch info form the Assembly which contains the Type. This can be used to get the Assembly name and version, etc...
        /// </summary>
        public static AssemblyName GetAssemblyInfo(this Type T)
        {
            // In some PCL profiles the line below is: var assembly = typeof(MyType).Assembly;
            var assembly = T.GetTypeInfo().Assembly;
            return new AssemblyName(assembly.FullName);
        }


        /// <summary>
        /// Returns the file location of the loaded assembly which contains the Type
        /// </summary>
        public static Uri GetPathToAssembly<T>() where T : Type
        {
            return GetPathToAssembly(typeof(T));
        }

        
        ///// <summary>
        ///// Returns the file location of the loaded assembly which contains the Type
        ///// </summary>
        //public static Uri GetPathToAssembly<T>(this T @type) where T : Type
        //{
        //    return GetPathToAssembly<T>();
        //}
        
        
        /// <summary>
        /// Returns the file location of the loaded assembly which contains the Type
        /// </summary>
        public static Uri GetPathToAssembly(this Type T, bool directoryOnly = true)
        {
            var assembly = T.GetTypeInfo().Assembly;

            if (directoryOnly)
            {
                return new Uri(Path.GetDirectoryName(assembly.Location));
            }
            else
            {
                return new Uri(assembly.Location);
            }
        }
    }
}

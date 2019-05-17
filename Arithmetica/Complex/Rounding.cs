﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Arithmetica
{
    public partial class Complex
    {
        /// <summary>
        /// Return the floor of the input, element-wise. The floor of the scalar x is the largest integer i.
        /// </summary>
        /// <param name="src">The source matrix.</param>
        /// <returns></returns>
        public static Complex Floor(Complex src) => Complex.Out(ArrayOps.Floor(src.variable));

        /// <summary>
        /// Return the round of the input, element-wise to nearest integer
        /// </summary>
        /// <param name="src">The source matrix.</param>
        /// <returns></returns>
        public static Complex Round(Complex src) => Complex.Out(ArrayOps.Round(src.variable));

        /// <summary>
        /// Return the truncated value of the input, element-wise. The truncated value of the scalar x is the nearest integer i which is closer to zero than x is. In short, the fractional part of the signed number x is discarded.
        /// </summary>
        /// <param name="src">The source matrix.</param>
        /// <returns></returns>
        public static Complex Trunc(Complex src) => Complex.Out(ArrayOps.Trunc(src.variable));

        /// <summary>
        /// Return the ceiling of the input, element-wise. The ceil of the scalar x is the smallest integer i, such that i >= x.
        /// </summary>
        /// <param name="src">The source matrix.</param>
        /// <returns></returns>
        public static Complex Ceil(Complex src) => Complex.Out(ArrayOps.Ceil(src.variable));

        /// <summary>
        /// Clip (limit) the values in an matrix. Given an interval, values outside the interval are clipped to the interval edges.For example, if an interval of[0, 1] is specified, values smaller than 0 become 0, and values larger than 1 become 1.
        /// </summary>
        /// <param name="src">The source matrix.</param>
        /// <param name="min">The minimum clip value.</param>
        /// <param name="max">The maximum clip value.</param>
        /// <returns></returns>
        public static Complex Clip(Complex src, float min, float max) => Complex.Out(ArrayOps.Clip(src.variable, min, max));

        /// <summary>
        /// Return the fractional and integral parts of an matrix, element-wise. The fractional and integral parts are negative if the given number is negative.
        /// </summary>
        /// <param name="src">The source matrix.</param>
        /// <returns></returns>
        public static Complex Frac(Complex src) => Complex.Out(ArrayOps.Frac(src.variable));

        /// <summary>
        /// Compute the standard deviation along the specified axis. 
        /// Returns the standard deviation, a measure of the spread of a distribution, of the matrix elements.The standard deviation is computed for the flattened matrix by default, otherwise over the specified axis.
        /// </summary>
        /// <param name="src">The source matrix.</param>
        /// <returns></returns>
        public static Complex Std(Complex src) => Complex.Out(ArrayOps.Std(src.variable));

        /// <summary>
        /// Compute the standard deviation along the specified axis. 
        /// Returns the standard deviation, a measure of the spread of a distribution, of the matrix elements.The standard deviation is computed for the flattened matrix by default, otherwise over the specified axis.
        /// </summary>
        /// <param name="src">The source matrix.</param>
        /// <returns></returns>
        public static Complex Std(Complex src, bool normbyN, int dimension) => Complex.Out(ArrayOps.Std(src.variable, dimension, normbyN));

    }
}

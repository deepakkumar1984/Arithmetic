﻿// ***********************************************************************
// Assembly         : Arithmetica
// Author           : Community
// Created          : 12-09-2018
//
// Last Modified By : Deepak Battini
// Last Modified On : 11-25-2018
// ***********************************************************************
// <copyright file="CpuAllocator.cs" company="Arithmetica">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arithmetica.Cpu
{
    /// <summary>
    /// Class CpuAllocator.
    /// Implements the <see cref="Arithmetica.IAllocator" />
    /// </summary>
    /// <seealso cref="Arithmetica.IAllocator" />
    public class CpuAllocator : IAllocator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CpuAllocator"/> class.
        /// </summary>
        public CpuAllocator()
        {
        }

        /// <summary>
        /// Allocates the specified element type.
        /// </summary>
        /// <param name="elementType">Type of the element.</param>
        /// <param name="elementCount">The element count.</param>
        /// <returns>Storage.</returns>
        public Storage Allocate(DType elementType, long elementCount)
        {
            return new CpuStorage(this, elementType, elementCount);
        }

        public void SetCurrent()
        {
        }
    }
}

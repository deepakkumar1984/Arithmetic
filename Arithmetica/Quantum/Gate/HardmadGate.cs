﻿using Arithmetica.LinearAlgebra.Single;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arithmetica.Quantum
{
    public class HardmadGate : QuantumGate
    {
        public HardmadGate(string name) : base(name)
        {
            Matrix = new ComplexMatrix(new Complex[,] {
                    { 1, 1 },
                    { 1, -1 },
                }) / Math.Sqrt(2);
        }
    }
}
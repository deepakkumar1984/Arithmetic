﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Arithmetica
{
    public partial class Rnd
    {
        public static void Bernoulli(Vector src, float p, int? seed = null)
            => ArrayOps.RandomBernoulli(src.variable, new SeedSource(seed), p);
        
        public static void Cauchy(Vector src, float median, float sigma, int? seed = null)
            => ArrayOps.RandomCauchy(src.variable, new SeedSource(seed), median, sigma);

        public static void Exponential(Vector src, float lambda, int? seed = null)
            => ArrayOps.RandomExponential(src.variable, new SeedSource(seed), lambda);

        public static void Geometric(Vector src, float p, int? seed = null)
            => ArrayOps.RandomGeometric(src.variable, new SeedSource(seed), p);

        public static void LogNormal(Vector src, float mean, float std, int? seed = null)
            => ArrayOps.RandomLogNormal(src.variable, new SeedSource(seed), mean, std);

        public static void Normal(Vector src, float mean, float std, int? seed = null)
            => ArrayOps.RandomNormal(src.variable, new SeedSource(seed), mean, std);

        public static void Uniform(Vector src, float min, float max, int? seed = null)
            => ArrayOps.RandomUniform(src.variable, new SeedSource(seed), min, max);
    }
}
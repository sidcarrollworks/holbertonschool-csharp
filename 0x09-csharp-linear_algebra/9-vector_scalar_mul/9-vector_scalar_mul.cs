using System;


    class VectorMath
    {
        public static double[] Multiply(double[] vector, double[] scalar)
        {
            double[] vec = new double[vector.Length];
            if (vector.Length == 2 || vector.Length == 3) {
                for ( int i = 0; i < vector.Length; i++) {
                    vec[i] = vector1[i] * scalar;
                }
                return vec;
            } else {
                return -1;
            }
        }
    }

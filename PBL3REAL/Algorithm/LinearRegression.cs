using System;
using System.Collections.Generic;
using System.Text;

namespace PBL3REAL.Algorithm
{
    public class LinearRegression
    {
        public double[] xVals { get; private set; }
        public double[] yVals { get; private set; }
        public double rSquared { get; private set; }
        public double yIntercept { get; private set; }
        public double slope { get; private set; }
        public double predictedValue { get; private set; }
        public LinearRegression(double[] xValss, double[] yValss)
        {
            this.xVals = xValss;
            this.yVals = yValss;
        }
        public void PredictData()
        {
            if (this.xVals.Length != this.yVals.Length)
            {
                throw new Exception("Input values should be with the same length.");
            }
            double sumOfX = 0;
            double sumOfY = 0;
            double sumOfXSq = 0;
            double sumOfYSq = 0;
            double sumCodeviates = 0;
            for (var i = 0; i < xVals.Length; i++)
            {
                var x = xVals[i];
                var y = yVals[i];
                sumCodeviates += x * y;
                sumOfX += x;
                sumOfY += y;
                sumOfXSq += x * x;
                sumOfYSq += y * y;
            }

            var count = xVals.Length;
            var ssX = sumOfXSq - ((sumOfX * sumOfX) / count);
            var ssY = sumOfYSq - ((sumOfY * sumOfY) / count);

            var rNumerator = (count * sumCodeviates) - (sumOfX * sumOfY);
            var rDenom = (count * sumOfXSq - (sumOfX * sumOfX)) * (count * sumOfYSq - (sumOfY * sumOfY));
            var sCo = sumCodeviates - ((sumOfX * sumOfY) / count);

            var meanX = sumOfX / count;
            var meanY = sumOfY / count;
            var dblR = rNumerator / Math.Sqrt(rDenom);

            rSquared = dblR * dblR;
            yIntercept = meanY - ((sCo / ssX) * meanX);
            slope = sCo / ssX;
        }
    }
}

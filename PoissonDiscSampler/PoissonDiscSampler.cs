using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoissonDiscSampler
{
    public class PoissonDiscSampler
    {

        public PoissonDiscSampler(double radius, int maxSamples, double[] xMin, double[] xMax)
        {
            if (xMin.Length != xMax.Length) throw new ArgumentOutOfRangeException("xMin","min and max bounds are invalid");
        }
    }
}

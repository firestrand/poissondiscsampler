using System;
using PoissonDiscSampler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PoissonDiscSamplerTests
{
    [TestClass]
    public class PoissonDiscSamplerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void PoissonDiscSamplerBoundLengthDifferenceThrowsException()
        {
            var min = new[] {0.0, 0.0};
            var max = new[] {10.0};
            var sampler = new PoissonDiscSampler.PoissonDiscSampler(5.0, 30, min, max);
        }
    }
}

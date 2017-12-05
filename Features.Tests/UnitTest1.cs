using System;
using Xunit;

namespace Features.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var class1 = new Class1();

            Assert.True(class1.soma(2,2) == 4);
            Assert.True(class1.soma(1,2) == 3);
        }
    }
}

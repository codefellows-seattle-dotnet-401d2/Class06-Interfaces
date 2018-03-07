using System;
using Xunit;
using TheFingerGame.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Tortoise tort = new Tortoise();
            tort.Distance = 25;
            Assert.Equal(25, tort.Distance);
        }
    }
}

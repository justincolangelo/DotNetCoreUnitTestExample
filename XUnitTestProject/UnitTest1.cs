using System;
using Xunit;
using DotNetCoreUnitTestExample.Controllers;
using System.Linq;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new ValuesController();
            var result = controller.Get();
            Assert.Equal(2, result.Value.Count());
        }
    }
}

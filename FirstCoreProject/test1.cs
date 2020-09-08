using System;
using Xunit;
using FirstLibrary;

namespace FirstCoreProject{


    public class test1{

        [Fact]
        public void TestName()
        {
            var ob = new Addition();
            Assert.Equal(ob.display(), "ok!".ToString());
            Assert.Equal(ob.add(2, 2), 4);
        }
    }
}
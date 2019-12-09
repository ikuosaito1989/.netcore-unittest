using System;
using Xunit;
using app;

namespace test
{
    public class UnitTest1
    {
        [Fact(DisplayName = "Mainが呼び出されること")]
        public void Main()
        {
            string[] args = {"one", "two", "three"};
            Program.Main(args);
        }

        [Fact(DisplayName = "正しい文字列が返ること")]
        public void Test()
        {
            var app = new Program();
            Assert.Equal(app.Test(), "Yeah!!");
        }
    }
}

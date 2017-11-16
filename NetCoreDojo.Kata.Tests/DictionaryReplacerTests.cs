using System;
using Xunit;
using Kata;
using System.Collections.Generic;

namespace Kata.Tests
{
    public class KataDictionaryReplacerTests
    {
        [Fact]
        public void Test1()
        {
            string output =  DictionaryReplacer.Replace("", new Dictionary<string, string>());
            
            Assert.Equal("", output);
        }

        [Fact]
        public void Test2()
        {
            string output = DictionaryReplacer.Replace("$temp$", new Dictionary<string, string>() {{"temp", "temporary"}});
            
            Assert.Equal("temporary", output);
        }

        [Fact]
        public void Test3()
        {
            string output = DictionaryReplacer.Replace("$temp$ here comes the name $name$", new Dictionary<string, string>() {
                {"temp", "temporary"}, {"name", "John Doe"}});
            
            Assert.Equal("temporary here comes the name John Doe", output);
        }

    }
}

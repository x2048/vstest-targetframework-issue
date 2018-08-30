using System;
using System.Net.Http;
using Xunit;


namespace ExampleTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          HttpClient client = new HttpClient();
          var result = client.GetAsync("https://fancyssl.hboeck.de/").Result;
        }
    }
}

using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Fizzler.Systems.HtmlAgilityPack
    .Test
{
    public class GeneralTest
    {
        [Fact]
        public void PassingTest()
        {
            var html = "<html><body><div AttributeIsThis=\"val\">agi</div></body></html>";
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var documentNode = htmlDocument.DocumentNode;

            var text = documentNode.QuerySelector("div").InnerText;

            Assert.Equal("agi", text);
        }        
    }
}

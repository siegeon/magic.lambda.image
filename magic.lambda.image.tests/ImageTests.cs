/*
 * Magic, Copyright(c) Thomas Hansen 2019 - 2020, thomas@servergardens.com, all rights reserved.
 * See the enclosed LICENSE file for details.
 */

using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using magic.node;
using magic.node.extensions;

namespace magic.lambda.image.tests
{
    public class ImageTests
    {
        [Fact]
        public void GenerateQrCode()
        {
            var lambda = Common.Evaluate("qr.generate:foo-bar\r\n   size:4");
            Assert.True(lambda.Children.First().Value is Stream);
        }
    }
}

/*
 * Magic, Copyright(c) Thomas Hansen 2019 - 2020, thomas@servergardens.com, all rights reserved.
 * See the enclosed LICENSE file for details.
 */

using System.IO;
using System.Linq;
using System.Drawing.Imaging;
using QRCoder;
using magic.node;
using magic.node.extensions;
using magic.signals.contracts;

namespace magic.lambda.image
{
    /// <summary>
    /// [qr.generate] slot for creating QR codes.
    /// </summary>
    [Slot(Name = "qr.generate")]
    public class QrCodeGenerator : ISlot
    {
        /// <summary>
        /// Slot implementation.
        /// </summary>
        /// <param name="signaler">Signaler that raised the signal.</param>
        /// <param name="input">Arguments to slot.</param>
        public void Signal(ISignaler signaler, Node input)
        {
            var data = input.GetEx<string>();
            var size = input.Children.FirstOrDefault(x => x.Name == "size")?.GetEx<int>() ?? 4;
            using (var generator = new QRCodeGenerator())
            {
                using (var qrData = generator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q))
                {
                    using (var code = new PngByteQRCode(qrData))
                    {
                        // Intentionally NOT disposing stream, it's anyways a MemoryStream
                        var bytes = code.GetGraphic(size);
                        var stream = new MemoryStream();
                        stream.Write(bytes, 0, bytes.Length);
                        stream.Flush();
                        stream.Position = 0;
                        input.Value = stream;
                    }
                }
            }
        }
    }
}

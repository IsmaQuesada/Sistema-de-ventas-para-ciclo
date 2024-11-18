using MessagingToolkit.QRCode.Codec;
using System.Drawing;

namespace appProyecto.Util
{
    class QuickResponse
    {
        public static Image QuickResponseGenerador(string input, int qrlevel)
        {

            string toenc = input;

            MessagingToolkit.QRCode.Codec.QRCodeEncoder qe = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();

            qe.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;

            qe.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L; // - Using LOW for more storage

            qe.QRCodeVersion = qrlevel;

            System.Drawing.Bitmap bm = qe.Encode(toenc);

            return bm;

        }
    }
}

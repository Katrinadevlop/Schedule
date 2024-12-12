using System.Drawing;

namespace Schedule
{
    internal class Captcha
    {
        private static Random random = new Random();

        public string Generate()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Range(0, 6).Select(_ => chars[random.Next(chars.Length)]).ToArray());
        }

        public Bitmap GetBitmap()
        {
            string captchaCode = Generate();
            Bitmap captchaBitmap = new Bitmap(200, 50);
            using (Graphics g = Graphics.FromImage(captchaBitmap))
            {
                g.Clear(Color.White);
                g.DrawString(captchaCode, new Font("Arial", 20), Brushes.Black, new PointF(10, 10));
            }
            return captchaBitmap;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalAndroid.io
{
    class ImageHandler
    {
        public static System.Drawing.Image LoadBase64Image(string baseinp)
        {
            var bytes = Convert.FromBase64String(baseinp);

            using (var imagestream = new System.IO.MemoryStream(bytes, 0, bytes.Length))
            {
                var image = System.Drawing.Image.FromStream(imagestream);
                return image;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace BookARoom.Utilities
{
    public class Tools
    {

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {

            ImageConverter converter = new ImageConverter();
            Image img = (Image)converter.ConvertFrom(byteArrayIn);

            return img;
        }
    }
}
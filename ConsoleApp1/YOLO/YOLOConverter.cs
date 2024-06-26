using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.YOLO
{
    public class YoloConverter
    {
        public static (float centerX, float centerY, float normWidth, float normHeight) ConvertToYoloFormat(float x, float y, float width, float height, int imageWidth, int imageHeight)
        {
            float centerX = x + width / 2.0f;
            float centerY = y + height / 2.0f;
            float normCenterX = centerX / imageWidth;
            float normCenterY = centerY / imageHeight;
            float normWidth = width / imageWidth;
            float normHeight = height / imageHeight;
            return (normCenterX, normCenterY, normWidth, normHeight);
        }
    }
}

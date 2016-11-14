using System;
using System.Drawing;

public class BitmapReader
{
    private Bitmap bitmap;

	public BitmapReader(String fileName)
	{
        bitmap = new Bitmap(fileName);
	}

    public Int16[] getBitmapSize()
    {
        return new Int16[] { Convert.ToInt16(bitmap.Width), Convert.ToInt16(bitmap.Height) };
    }

    public Int16[] getPixelColorAsInt(Int16 xCoordinate, Int16 yCoordinate)
    {
        Color pixelColor = bitmap.GetPixel(xCoordinate, yCoordinate);
        return new Int16[] {pixelColor.R};
    }
}

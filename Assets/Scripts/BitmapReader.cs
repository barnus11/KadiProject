using System;
using UnityEngine;

public class BitmapReader
{
    private Texture2D bitmap;

	public BitmapReader(Texture2D bitmap)
	{
        this.bitmap = bitmap;
	}

    public int[] getBitmapSize()
    {
        return new int[] {bitmap.width, bitmap.height};
    }

    public int getPixelColorAsInt(int xCoordinate, int yCoordinate)
    {
        Color pixelColor = bitmap.GetPixel(xCoordinate, yCoordinate);
        return (int)(pixelColor.r * 255);
    }
}

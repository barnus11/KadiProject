using UnityEngine;
using System.Collections;

public class PathFinder : MonoBehaviour {

    public Texture2D mapTexture;
    BitmapReader reader;
    private int[,] mapMatrix;

    void Start() {
        reader = new BitmapReader(mapTexture);
    }

    private void drawMapMatrix()
    {
        mapMatrix = new int[reader.getBitmapSize()[0], reader.getBitmapSize()[1]];

        for (int i = 0; i < reader.getBitmapSize()[0]; i++)
        {
            for (int j = 0; j < reader.getBitmapSize()[1]; j++)
            {
                if (reader.getPixelColorAsInt(i, j) == 0)
                {
                    mapMatrix[i, j] = 1;
                }
                if (reader.getPixelColorAsInt(i, j) == 7)
                {
                    mapMatrix[i, j] = 0;
                }
            }
        }
    }

    void Update() {

        foreach (Transform child in transform)
        { 
            Debug.Log(getAIPosition(child.gameObject));
        }
    }

    private Vector2 getAIPosition(GameObject enemy)
    {
        return enemy.transform.position;
    }
}

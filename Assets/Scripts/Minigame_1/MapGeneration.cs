using UnityEngine;

public class MapGeneration : MonoBehaviour {

    private BitmapReader reader;
    public Texture2D layer1GenereationMap, layer2GenerationMap;
    public GameObject wall, walkway, coin, enemy, player, boost, door;

    void Start ()
    {
        reader = new BitmapReader(layer1GenereationMap);
        generateMap();
        reader = new BitmapReader(layer2GenerationMap);
        generateMap();
	}
	
    private void generateMap()
    {
        int k = 1, l = 1;
        Vector2 pos = new Vector2(-reader.getBitmapSize()[0] / 2 + 0.5F, -reader.getBitmapSize()[1] / 2 + 0.5F);
        
        for (int x = 0; x < reader.getBitmapSize()[1]; x++)
        {
            for (int y = 0; y < reader.getBitmapSize()[0]; y++)
            {
                GameObject objectToGenerate = getObjectGenerated(y, x);
                GameObject parentObject = getParent(objectToGenerate);
                if (objectToGenerate != null) {
                    Instantiate(objectToGenerate, pos, new Quaternion(0, 0, 0, 0), parentObject.transform);
                }
                pos.Set(-reader.getBitmapSize()[0] / 2 + 0.5F + k, pos.y);
                k++;
            }
            pos.Set(-reader.getBitmapSize()[0] / 2 + 0.5F, -reader.getBitmapSize()[1] / 2 + 0.5F + l);
            k = 1;
            l++;
        }
    }

    private GameObject getObjectGenerated(int xCoordinate, int yCoordinate)
    {
        switch (reader.getPixelColorAsInt(xCoordinate, yCoordinate))
        {
            case 0:
                return wall;
            case 1:
                return enemy;
            case 2:
                return player;
            case 3:
                return door;
            case 4:
                return boost;
            case 5:
                return coin;
            case 6:
                return null;
            case 7:
                return walkway;
            default:
                throw new System.Exception("No object set for pixel (" + xCoordinate + ", " + yCoordinate +")");
        }
    }

    private GameObject getParent(GameObject objectGenerated)
    {
        if (objectGenerated == wall || objectGenerated == walkway || objectGenerated == door)
        {
            return GameObject.Find("Map(Clone)");
        }

        else if (objectGenerated == enemy)
        {
            return GameObject.Find("AI(Clone)");
        }

        else if(objectGenerated == boost || objectGenerated == coin){
            return GameObject.Find("Collectibles(Clone)");
        }
        return transform.parent.gameObject;
    }

    private bool GenerateCoin(bool isWalkway, Vector2 pos)
    {
        if (isWalkway)
        {
            Instantiate(coin, pos, new Quaternion(0, 0, 0, 0));
            return true;
        }
        return false;
    }
}

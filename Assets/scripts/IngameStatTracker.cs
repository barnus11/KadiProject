using UnityEngine;

public class IngameStatTracker : MonoBehaviour
{
    public GameObject healthDisplayUnit;
    public RectTransform parentTransform;
    public Canvas canvas;
    public int prevHealth = 0;
    public int health;
    GameObject[] healthDisplay;
    void Update()
    {
        if (health != prevHealth)
        {
            for (int i = 0; i < prevHealth; i++)
                Destroy(healthDisplay[i]);
            healthDisplay = new GameObject[health];
            RectTransform canvasRectTransform = canvas.GetComponent<RectTransform>();
            for (int i = 0; i < health; i++)
            {
                healthDisplay[i] = (GameObject)Instantiate(healthDisplayUnit, new Vector2(0,0), new Quaternion(0, 0, 0, 0), parentTransform);
                healthDisplay[i].GetComponent<Transform>().localPosition = new Vector2(parentTransform.rect.xMin + 30*i, parentTransform.rect.height - 10);
            }
            prevHealth = health;
        }
    }
}

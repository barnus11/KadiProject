using UnityEngine;
using System.Collections;

public class IngameStatTracker : MonoBehaviour
{
    public Object healthDisplayUnit;
    public Canvas canvas;
    public int prevHealth = 0;
    public int health;
    Object[] healthDisplay;
    void Update()
    {
        if (health != prevHealth)
        {
            for (int i = 0; i < prevHealth; i++)
                Destroy(healthDisplay[i]);
            healthDisplay = new Object[health];
            for (int i = 0; i < health; i++)
            {
                healthDisplay[i] = (Instantiate(healthDisplayUnit, new Vector3(i * 40, 50, 0), new Quaternion(0, 0, 0, 0), canvas.transform));
            }
        }
    }
}

using UnityEngine;
using System.Collections;

public class HpPlus : MonoBehaviour {
    public IngameStatTracker target;
    public void Click()
    {
        target.health++;
    } 
}

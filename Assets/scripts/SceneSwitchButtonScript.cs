using UnityEngine;
using System.Collections;

public class SceneSwitchButtonScript : MonoBehaviour {
    public string targetscene;
    public void Click()
    {
        Application.LoadLevel(targetscene);
    }
}

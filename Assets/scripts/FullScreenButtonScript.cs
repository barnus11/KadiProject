using UnityEngine;
using System.Collections;

public class FullScreenButtonScript : MonoBehaviour {
    public void Click()
    {
        if (Screen.fullScreen)
            Screen.fullScreen = false;
        else
            Screen.fullScreen = true;
    }
}

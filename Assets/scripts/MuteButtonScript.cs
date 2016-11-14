using UnityEngine;
using System.Collections;

public class MuteButtonScript : MonoBehaviour {
    public AudioSource audio;
    public UnityEngine.UI.Image image;
    public UnityEngine.UI.Text text;
    public void Click()
    {
        if (audio.mute)
            audio.mute = false;
        else
            audio.mute = true;
    }
    void Update()
    {
        if (audio.mute)
        {
            image.color = new Color(255, 0, 0);
            text.text = "Unmute";
        }
        else
        {
            image.color = new Color(0, 255, 0);
            text.text = "Mute";
        }
    }
}

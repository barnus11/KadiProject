using UnityEngine;
using System.Collections;

public class ItemListElementScript : MonoBehaviour {
    public GameObject pic;
    public GameObject button;
    public GameObject text;
    public void Initialize()
    {
        button = new GameObject();
        pic = new GameObject();
        text = new GameObject();
        button.AddComponent<UnityEngine.UI.Button>();
        pic.transform.parent = button.transform;
        text.transform.parent = button.transform;
        pic.AddComponent<UnityEngine.UI.Image>();
        text.AddComponent<UnityEngine.UI.Text>();
    }
}

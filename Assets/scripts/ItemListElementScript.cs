using UnityEngine;
using System.Collections;

public class ItemListElementScript : MonoBehaviour {
    public GameObject pic;
    public GameObject mainobj;
    public GameObject text;
    public void Initialize()
    {
        mainobj = new GameObject();
        pic = new GameObject();
        text = new GameObject();
        mainobj.AddComponent<RectTransform>();
        pic.AddComponent<RectTransform>();
        text.AddComponent<RectTransform>();
        mainobj.AddComponent<UnityEngine.UI.Button>();
        pic.GetComponent<RectTransform>().parent = mainobj.GetComponent<RectTransform>();
        text.GetComponent<RectTransform>().parent = mainobj.GetComponent<RectTransform>();
        pic.AddComponent<UnityEngine.UI.Image>();
        text.AddComponent<UnityEngine.UI.Text>();
        pic.GetComponent<RectTransform>().anchorMin = new Vector2(0, 0);
        pic.GetComponent<RectTransform>().anchorMax = new Vector2(0.3f, 1);
        text.GetComponent<RectTransform>().anchorMin = new Vector2(0.3f, 0);
        text.GetComponent<RectTransform>().anchorMax = new Vector2(1, 1);
    }
}

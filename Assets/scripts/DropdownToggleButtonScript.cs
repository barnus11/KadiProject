using UnityEngine;
using System.Collections;

using System.Collections.Generic;

public class DropdownToggleButtonScript : MonoBehaviour {
    public List<ItemListElementScript> elements = new List<ItemListElementScript>();
    public int members = 1;
    public RectTransform panelTransform;
    public CanvasGroup canvas;
    public bool on;
    public void Clicked()
    {
        if(on == false)
        {
            canvas.alpha = 1;
            canvas.interactable = true;
            canvas.blocksRaycasts = true;
            on = true;
            panelTransform.sizeDelta.Set(panelTransform.sizeDelta.x,members);
        }
        else
        {
            canvas.alpha = 0;
            canvas.interactable = false;
            canvas.blocksRaycasts = false;
            on = false;
        }
    }
}
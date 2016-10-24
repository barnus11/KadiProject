using UnityEngine;
using System.Collections;

public class CanvasOpenCloseScript : MonoBehaviour {
	public UnityEngine.CanvasGroup toggleOn;
	public UnityEngine.CanvasGroup toggleOff;

	public void Open () {
		toggleOn.alpha = 1;
		toggleOn.interactable = true;

	}
	public void Close () {
		toggleOff.alpha = 0;
		toggleOff.interactable = false;
	}

}
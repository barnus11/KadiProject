using UnityEngine;
using System.Collections;

public class VolumeSliderScript : MonoBehaviour {
	public UnityEngine.UI.Slider slider;
	public AudioSource audio;
	public void ChangeVolume()
	{
		audio.volume = slider.value;
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasToggle:MonoBehaviour
{
	Canvas myCanvas;

	void Awake ()
	{
		myCanvas = transform.GetComponent<Canvas> ();
	}

	public void Toggle ()
	{
		if (myCanvas.enabled) {
			myCanvas.enabled = false;
		} else {
			myCanvas.enabled = true;
		}
	}
}

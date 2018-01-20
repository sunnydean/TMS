using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{
	public GameObject audioInputObject;
	public float threshold = 1.0f;
	MicrophoneInput micIn;
	public bool c = false;
	public bool d = false;
	public bool fireball = false;
	public GameObject tst;

	void Start ()
	{
		if (audioInputObject == null)
			audioInputObject = GameObject.Find ("MicMonitor");
		micIn = (MicrophoneInput)audioInputObject.GetComponent ("MicrophoneInput");
	}
    
	// Update is called once per frame
	void FixedUpdate ()
	{
		float l = micIn.loudness;
		if (l > threshold) {
			int f = (int)micIn.frequency; 
			if (f >= 237 && f <= 255) {
				c = true;
				Debug.Log ("Middle-C played!");
			}
			if (f >= 267 && f <= 278) {
				d = true;
				Debug.Log ("d played!");
			}

		}
		if (c && d) {
			tst.GetComponent<MauseSelecting> ().plat = true;
			fireball = true;
			c = false;
			d = false;
		} else {
			tst.GetComponent<MauseSelecting> ().plat = false;

			fireball = false;
		}


	}

}
    
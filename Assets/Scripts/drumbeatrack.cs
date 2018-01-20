using UnityEngine;
using System.Collections;

public class drumbeatrack : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		this.GetComponent<AudioSource> ().volume = 0.12f;
		this.GetComponent<AudioSource> ().mute = false;
	}

	// Update is called once per frame
	void Update ()
	{
		if (this.GetComponent<magicspellsofdeathandglory> ().atar != null) {
			this.GetComponent<AudioSource> ().volume = 0.3f;
		} else {
			this.GetComponent<AudioSource> ().volume = 0.04f;
		}
           
	}
}


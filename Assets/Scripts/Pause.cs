using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
	bool CanPause = true;
	public GameObject p;
	// Use this for initialization
	void Start ()
	{
		
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (CanPause) {
                p.SetActive(true);
				Time.timeScale = 0;
				CanPause = false;

			} else {
                p.SetActive(false);
				Time.timeScale = 1;
				CanPause = true;
			}
		}

	}

	public void exit ()
	{
		Application.Quit ();
		Debug.Log ("quit");
	}
}
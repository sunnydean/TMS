using UnityEngine;
using System.Collections;

public class MauseSelecting : MonoBehaviour
{
	public string target;
	public GameObject thetargetscanvas;
	public GameObject thetargetscanvasclone;
	public GameObject Thetarget;
	public GameObject theattack;
	public Transform player;
	public bool plat;
	// Use this for initialization
	void Start ()
	{
		theattack.SetActive (false);
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {

			if (thetargetscanvas != null) {
				theattack.SetActive (false);

				thetargetscanvas.GetComponent<CanvasGroup> ().alpha = 0;
				Thetarget.GetComponent<Light> ().enabled = false;
				thetargetscanvas = null;
				Thetarget = null;
				thetargetscanvasclone = null;

			}
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.tag == "gumba") {
					Thetarget = hit.collider.gameObject;
					thetargetscanvas = Thetarget.GetComponent<navmeshai2> ().thetargetscanvas;
					thetargetscanvas.GetComponent<CanvasGroup> ().alpha = 1;
					Thetarget.GetComponent<Light> ().enabled = true;
					thetargetscanvasclone = Thetarget.GetComponent<navmeshai2> ().thetargetscanvas;
					theattack.SetActive (true);
				}


				if (hit.transform.tag == "slime") {

					Thetarget = hit.collider.gameObject;
					thetargetscanvas = Thetarget.GetComponent<slimescanvas> ().thetargetscanvas;
					thetargetscanvas.GetComponent<CanvasGroup> ().alpha = 1;
					Thetarget.GetComponent<Light> ().enabled = true;
					thetargetscanvasclone = Thetarget.GetComponent<slimescanvas> ().thetargetscanvas;
					theattack.SetActive (true);
				}
				if (hit.transform.tag == "Dragon") {
					Debug.Log ("dragon selected");
					GameObject.Find ("Guitar_Things").transform.GetChild (0).gameObject.SetActive (true);
					GameObject.Find ("Guitar_Things").transform.GetChild (1).gameObject.SetActive (true);
				}
				if (hit.collider.gameObject.tag == "blink") {

					Thetarget = hit.collider.gameObject;
                    transform.parent.transform.position = Thetarget.transform.position;

                }
            }
			if (Thetarget != null)
			if (Thetarget.activeSelf != true) {
				Destroy (thetargetscanvas);
				thetargetscanvas = null;
				Thetarget = null;
				thetargetscanvasclone = null;
				theattack.SetActive (false);

			}
		}
		
	}
}
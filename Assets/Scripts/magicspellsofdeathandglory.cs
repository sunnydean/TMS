
using UnityEngine;
using System.Collections;

public class magicspellsofdeathandglory : MonoBehaviour
{
	public GameObject targetingsc;
	bool fair = false;
	private GameObject theactualtarget;
	public GameObject atar;
	private ParticleSystem a;
	public GameObject makedmg;
	public GameObject fireblastcast;
	// Use this for initialization
	int fireballdmg = 80;

	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

        
		test playerScript = this.gameObject.GetComponent<test> ();
        
		MauseSelecting target = targetingsc.GetComponent<MauseSelecting> ();
		theactualtarget = target.Thetarget;
		if (target.Thetarget != null) {
			if (theactualtarget != null && theactualtarget.tag != "blink") {

				atar = theactualtarget.transform.Find ("Fireball").gameObject;
				a = atar.GetComponent<ParticleSystem> ();
				makedmg = target.thetargetscanvasclone.transform.Find ("HPImage").gameObject;


			}
			// if (Input.GetMouseButton(0))
			//{
			//	damag(fireballdmg);
			//}

			if (playerScript.fireball) {
				StartCoroutine (damag (fireballdmg));

			}
		} else {
			atar = null;
			a = null;
			makedmg = null;
		}
        
	}

	IEnumerator damag (int dmg)
	{
		a.Play ();
		yield return new WaitForSeconds (0.6f);
		makedmg.GetComponent<NewBehaviourScript> ().TakeDamage (dmg);
	}
}


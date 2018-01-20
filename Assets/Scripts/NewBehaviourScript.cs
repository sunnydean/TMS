using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
	Image myImage;
	public float hpMax;
	public float hpCurrent;
	private float multiplier;
	public float damaGE;
	float fillamount;
	public GameObject targetingsc;

	void Awake ()
	{
		myImage = GetComponent<Image> ();
	}

	void Start ()
	{

		multiplier = hpMax / 100; // 2
		fillamount = (hpCurrent / multiplier) / 100; // 1
		//TakeDamage (damaGE);
	}

	void Update ()
	{
     
		if (fillamount <= 0) {
			targetingsc.SetActive (false);  
			this.transform.parent.gameObject.SetActive (false);
		}

	}

	public void TakeDamage (float damageAmount)
	{
		hpCurrent -= damageAmount; //195
		fillamount = (hpCurrent / multiplier) / 100;
		myImage.fillAmount = fillamount;

	}
}
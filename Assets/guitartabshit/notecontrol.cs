using UnityEngine;
using System.Collections;

public class notecontrol : MonoBehaviour {

	//public Transform burst;

	
	void Start () {
		if (gameObject.name == "S1Note(Clone)")
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.21f, -1, 0);
		}
		if (gameObject.name == "S2Note(Clone)")
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.16f, -1, 0);
		}
		if (gameObject.name == "S3Note(Clone)")
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (-.07f, -1, 0);
		}
		if (gameObject.name == "S4Note(Clone)")
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (.05f, -1, 0);
		}
		if (gameObject.name == "S5Note(Clone)")
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (.13f, -1, 0);
		}
		if (gameObject.name == "S6Note(Clone)")
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (.22f, -1, 0);
		}
	}
	
	void Update ()
	{
		if ((songcontrol.destroyASD == "y") && (gameObject.name == "S1Note(Clone)") )
		{
			
			//Instantiate(burst,transform.position,burst.rotation);
			songcontrol.totalCorrect += 1;
			songcontrol.destroyASD = "n";
			Destroy (gameObject);
			
		}
		if ((songcontrol.destroyB == "y") && (gameObject.name == "S2Note(Clone)"))
		{
			
			//Instantiate(burst,transform.position,burst.rotation);
			songcontrol.totalCorrect += 1;
			songcontrol.destroyB = "n";
			Destroy (gameObject);
		}
		if ((songcontrol.destroyC == "y") && (gameObject.name == "S3Note(Clone)"))
		{
			
			//Instantiate(burst,transform.position,burst.rotation);
			songcontrol.totalCorrect += 1;
			songcontrol.destroyC = "n";
			Destroy (gameObject);
		}
		if ((songcontrol.destroyD == "y") && (gameObject.name == "S4Note(Clone)"))
		{
			
		//	Instantiate(burst,transform.position,burst.rotation);
			songcontrol.totalCorrect += 1;
			songcontrol.destroyD = "n";
			Destroy (gameObject);
		}
		if ((songcontrol.destroyE == "y") && (gameObject.name == "S5Note(Clone)"))
		{
			
			//Instantiate(burst,transform.position,burst.rotation);
			songcontrol.totalCorrect += 1;
			songcontrol.destroyE = "n";
			Destroy (gameObject);
		}
		
	}
	void OnTriggerEnter2D()
		
	{
		GetComponent<SpriteRenderer> ().color = new Color (0, 1, 0);
		
	}
	void OnTriggerExit2D()
	{
		GetComponent<SpriteRenderer> ().color = new Color (1, 0, 0);
		Destroy (gameObject, .25f);
	}
}

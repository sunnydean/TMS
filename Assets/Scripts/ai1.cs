using UnityEngine;
using System.Collections;

public class ai1 : MonoBehaviour
{
	public float speed;
	public Transform player;
	public float gravity = 3.0f;
	public int playerHP;
	public int Damage;
	Vector3 velocity;
	Vector3 moveDirection = Vector3.zero;
	int a = 1;
	// Use this for initialization
	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update ()
	{
		
		transform.LookAt (player);
		if (Vector3.Distance (player.position, transform.position) < 20) {
			doDamage ();

		}
	}


	public void doDamage ()
	{
		if (a == 1)
			StartCoroutine (dmg ());
	}

	IEnumerator dmg ()
	{
		a = 2;
		
		Debug.Log ("dada");
		yield return new WaitForSeconds (1);

		//yield return new WaitForSeconds (1);
		GameObject.Find ("Canvas/Playercanvas/HPImage").GetComponent<NewBehaviourScript> ().TakeDamage (20);
		a = 1;
	}
}

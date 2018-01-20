using UnityEngine;
using System.Collections;

public class cyrcle : MonoBehaviour
{
	public GameObject targ;
	public GameObject dragongo;
	public float speed;
	public float speed1;

	public bool circlingbitsch = true;
	// Use this for initialization
	void Start ()
	{
		
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (circlingbitsch) {

			transform.RotateAround (targ.transform.position, Vector3.up, speed * Time.deltaTime);
		} else {
			transform.LookAt (dragongo.transform);
			transform.position += transform.forward * Time.deltaTime * speed1;
			if (Vector3.Distance (transform.position, dragongo.transform.position) < 100) {
				speed1 = 0;
			}

		}
	}
}

using UnityEngine;
using System.Collections;

public class Ai : MonoBehaviour
{






    public Transform destination;

    private UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        agent = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();

        agent.SetDestination(destination.position);
    }
    /*float Speed = 20f;
	Vector3 way = new Vector3 ();
	public GameObject player;
	public bool attacking = false;
	public bool attack = false;
	// Use this for initialization
	void Start ()
	{
		Wander ();
	}

	void Update ()
	{
		if (attack == false) {
			transform.position += transform.TransformDirection (Vector3.forward) * Speed * Time.deltaTime;
		}
		if (attacking == false) {
			if ((transform.position - way).magnitude < 3) {
				Wander ();
			}
		}
		if ((transform.position - player.transform.position).magnitude < 100) {
			attacking = true;
			rampage ();
			Debug.Log ("ata");
		}
	}

	void Wander ()
	{
		way = Random.insideUnitSphere * 47;
		way.y = 265.52f;
		transform.LookAt (way);

      
	}

	void rampage ()
	{
		// transform.position += transform.TransformDirection(Vector3.forward) * Speed * Time.deltaTime;

		way = player.transform.position;
		way.y = 265.52f;
		transform.LookAt (player.transform.position);
		if ((transform.position - player.transform.position).magnitude < 10) {
			attack = true;
			transform.LookAt (player.transform.position);
		} else {
			attack = false;
		}
	}*/
}

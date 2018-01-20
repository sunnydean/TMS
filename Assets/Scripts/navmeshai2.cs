using UnityEngine;
using System.Collections;

public class navmeshai2 : MonoBehaviour
{
	int a = 1;
	public GameObject thetargetscanvas;

	private UnityEngine.AI.NavMeshAgent agent;
	public GameObject player;
	private bool chase;
	public float distance;
	public Vector3 inipos;
	private Vector3 canvaspos;

	void Start ()
	{
		canvaspos = new Vector3 (200, -5);

		inipos = this.transform.position;
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		thetargetscanvas = Instantiate (Resources.Load ("GoombaCanvas"), canvaspos, Quaternion.Euler (0, 0, 0)) as GameObject;
		thetargetscanvas.transform.parent = GameObject.Find ("Canvas").transform;
		thetargetscanvas.GetComponent<CanvasGroup> ().alpha = 0;
		thetargetscanvas.GetComponentInChildren<NewBehaviourScript> ().targetingsc = this.gameObject;
	}

	void Update ()
	{

		distance = Vector3.Distance (player.transform.position, this.transform.position);
		if (distance < 60) {
			chase = true;
			agent.SetDestination (player.transform.position);
		} else {


			transform.position = Vector3.MoveTowards (transform.position, inipos, Time.deltaTime * 50);
			chase = false;

		}
		if (chase) {
			if (!agent.pathPending) {
				if (agent.remainingDistance <= agent.stoppingDistance) {
					if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f) {
						doDamage ();
					}
				}
			}
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

		//Debug.Log("dada");
		yield return new WaitForSeconds (1);

		//yield return new WaitForSeconds (1);
		GameObject.Find ("Canvas/Playercanvas/HPImage").GetComponent<NewBehaviourScript> ().TakeDamage (20);
		a = 1;
	}
}
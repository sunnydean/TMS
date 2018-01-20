using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class QuestEnter : MonoBehaviour
{
	
	public Text MainQuest;
	public Text SubQuest;
	public GameObject Mouse12;
	public GameObject Mouse2;
	public GameObject Booty;
	public GameObject cape;
	public GameObject guitar;
	public GameObject theHood;
	public GameObject Mouse1;
	public GameObject ligt;
	public GameObject arrow;

	public GameObject questman;
	// Use this for initialization
	void Awake ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerStay (Collider col)
	{
		if (col.transform.tag == "Player") {
			Debug.Log ("da");
			MainQuest.text = "Get your equipment!";
			SubQuest.text = "M2 to pick it up";
			Mouse2.GetComponent<CanvasGroup> ().alpha = 1;
		}   
		if (Input.GetMouseButtonDown (1)) {
			
			RaycastHit hit;
	
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider.tag == "equipment") {
					cape.GetComponent<MeshRenderer> ().enabled = true;
					guitar.GetComponent<MeshRenderer> ().enabled = true;
					theHood.GetComponent<SkinnedMeshRenderer> ().enabled = true;
					arrow.SetActive (true);
					ligt.SetActive (true);
					MainQuest.text = "Save your cabbage";
					SubQuest.text = "M1= target slime";
					Mouse2.GetComponent<CanvasGroup> ().alpha = 0;
					Mouse1.GetComponent<CanvasGroup> ().alpha = 1;
					questman.SetActive (true);
					Booty.SetActive (false);

				}
			}
		}
	}
}
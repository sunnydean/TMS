using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class NPC_Quest : MonoBehaviour
{
	public List<string> titles = new List<string> ();
	public List<string> texts = new List<string> ();
	public List<string> givers = new List<string> ();
	public List<int> rewards = new List<int> ();
	public List<Transform> scripts = new List<Transform> ();

	public List<Quest> quests = new List<Quest> ();
	Canvas giverCanvas;


	void Awake ()
	{
		giverCanvas = GameObject.FindWithTag ("QuestAssignment").GetComponent<Canvas> ();
	}

	void Start ()
	{
		DeclareQuests ();
		Debug.Log (quests.Count);
	}

	void DeclareQuests ()
	{
		for (int i = 0; i < titles.Count; i++) {
			Quest quest = new Quest (givers [i], titles [i], texts [i], rewards [i], scripts [i], false);
			quests.Add (quest);
		}
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.transform.tag == "Player") {
			if (quests.Count != 0) {
				if (!QuestHolder.quests.Contains (quests [0]) || quests [0].completed) {
					col.transform.GetComponent<QuestHolder> ().lastQuest = quests [0];
					giverCanvas.transform.GetChild (0).GetChild (0).GetComponent<Text> ().text = quests [0].title;
					giverCanvas.transform.GetChild (0).GetChild (1).GetComponent<Text> ().text = quests [0].text;
					if (quests [0].completed == false && QuestHolder.quests.Contains (quests [0]) == false) {
						giverCanvas.transform.GetChild (0).GetChild (2).GetChild (0).GetComponent<Text> ().text = "Accept";
					} else if (quests [0].completed == true) {
						giverCanvas.transform.GetChild (0).GetChild (2).GetChild (0).GetComponent<Text> ().text = "Complete";
					}
					giverCanvas.enabled = true;
					col.transform.GetComponent<QuestHolder> ().currentNPC = gameObject;
				}
			}
		}
	}
}

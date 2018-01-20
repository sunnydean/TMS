using UnityEngine;
using System.Collections;

public class Tutorial_2 : MonoBehaviour
{

	void Start ()
	{
		//enable TP script
		Transform spawnObjs = GameObject.Find ("Tutorial_2_spawns").transform;
		for (int i = 0; i < spawnObjs.childCount; i++) {
			spawnObjs.GetChild (i).gameObject.SetActive (true);
		}
		GameObject.Find ("Tutorial_1_NPC").transform.position = new Vector3 (8300, 530, 5970);
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.transform.name == "ForceField") {

			for (int i = 0; i < QuestHolder.quests.Count; i++) {
				if (QuestHolder.quests [i].title == "Go in the village") {
					QuestHolder.quests [i].completed = true;
				}
			}
			Debug.Log ("SHIT HAPPENED");
		}
	}
}

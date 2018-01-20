using UnityEngine;
using System.Collections;

public class Tutorial_1 : MonoBehaviour
{
	public Transform equipment;

	void Start ()
	{
		Transform.Instantiate (equipment, new Vector3 (9566, 1116, 7200), Quaternion.identity);
	}

	void OnTriggerEnter (Collider col)
	{
		Debug.Log (col.transform.name);
		if (col.transform.name == equipment.name + "(Clone)") {
			Debug.Log (col.transform.name);
			Destroy (col.gameObject);
			for (int i = 0; i < QuestHolder.quests.Count; i++) {
				if (QuestHolder.quests [i].title == "Get your equipment!") {
					QuestHolder.quests [i].completed = true;
				}
			}
			//transform.parent.GetChild (0).GetComponent<SkinnedMeshRenderer> ().enabled = true;
			//transform.parent.GetChild (1).GetComponent<MeshRenderer> ().enabled = true;
			//transform.parent.GetChild (2).GetComponent<MeshRenderer> ().enabled = true;
			//transform.parent.GetChild (3).GetComponent<MeshRenderer> ().enabled = true;
		}
	}
}

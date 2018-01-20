using UnityEngine;
using System.Collections;

public class RedBox : MonoBehaviour
{

	GameObject player;
	public Transform redBox;

	void Awake ()
	{
		player = GameObject.FindWithTag ("Player");
	}

	void Start ()
	{
		Instantiate (redBox, new Vector3 (-1368, 573, -400), Quaternion.identity);
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.transform.name == redBox.name + "(Clone)") {
			Destroy (col.gameObject);
			for (int i = 0; i < QuestHolder.quests.Count; i++) {
				if (QuestHolder.quests [i].title == "Red box!") {
					QuestHolder.quests [i].completed = true;
				}
			}
		}
	}
}

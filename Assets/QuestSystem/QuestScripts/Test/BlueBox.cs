using UnityEngine;
using System.Collections;

public class BlueBox : MonoBehaviour
{
	public Transform blueBox;

	void Start ()
	{
		Instantiate (blueBox, new Vector3 (-1368, 573, -500), Quaternion.identity);
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.transform.name == blueBox.name + "(Clone)") {
			Destroy (col.gameObject);
			for (int i = 0; i < QuestHolder.quests.Count; i++) {
				if (QuestHolder.quests [i].title == "Blue box!") {
					QuestHolder.quests [i].completed = true;
				}
			}
		}
	}
}

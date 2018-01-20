using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class QuestHolder : MonoBehaviour
{
	public static List<Quest> quests = new List<Quest> ();
	public Quest lastQuest;
	public GameObject currentNPC;
	public GameObject button;
	GameObject selectedQuest;

	void Awake ()
	{
		selectedQuest = GameObject.FindWithTag ("SelectedQuest");
	}

	public void InteractWithQuest ()
	{
		if (GameObject.FindWithTag ("QuestAssignment").transform.GetChild (0).GetChild (2).GetChild (0).GetComponent<Text> ().text == "Accept") {
			quests.Add (lastQuest);
			GameObject newButton = Instantiate (button, Vector3.zero, Quaternion.identity) as GameObject;
			newButton.transform.SetParent (GameObject.FindWithTag ("QuestButtonHolder").transform, false);
			newButton.transform.GetChild (0).GetComponent<Text> ().text = lastQuest.title;
			newButton.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0.05f, -(quests.Count - 1) * 20);
			Transform questScript = Instantiate (lastQuest.scriptObj, gameObject.transform.position, Quaternion.identity) as Transform;
			questScript.parent = transform;

			newButton.GetComponent<Button> ().onClick.AddListener (delegate() {
				selectedQuest.GetComponent<CanvasToggle> ().Toggle ();
				selectedQuest.transform.GetChild (0).GetChild (0).GetComponent<Text> ().text = quests [(int)newButton.GetComponent<RectTransform> ().anchoredPosition.y / -20].title;
				selectedQuest.transform.GetChild (0).GetChild (1).GetComponent<Text> ().text = quests [(int)newButton.GetComponent<RectTransform> ().anchoredPosition.y / -20].text;
			});

		} else {
			Quest compQuest = currentNPC.GetComponent<NPC_Quest> ().quests [0];
			currentNPC.GetComponent<NPC_Quest> ().quests.RemoveAt (0);
			bool isMyQuest = false;
			Debug.Log (quests.Count);
			for (int i = 0; i < quests.Count; i++) {
				if (isMyQuest) {
					GameObject.FindWithTag ("QuestButtonHolder").transform.GetChild (i).GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0.05f, -i * 20);
				}
				if (!isMyQuest && GameObject.FindWithTag ("QuestButtonHolder").transform.GetChild (i).GetChild (0).GetComponent<Text> ().text == compQuest.title) {
					Debug.Log ("Found");
					isMyQuest = true;
					Destroy (GameObject.FindWithTag ("QuestButtonHolder").transform.GetChild (i).gameObject);
					currentNPC.GetComponent<Collider> ().enabled = false;
					currentNPC.GetComponent<Collider> ().enabled = true;
				}
			}
			quests.Remove (compQuest);
			Destroy (transform.GetChild (transform.childCount - 1).gameObject);
		}
	}

	/*public void Abandon ()
	{
		
	}*/

}


using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class QuestManager : MonoBehaviour
{
	public GameObject FIRE;
	public GameObject cabbage;
	bool CabbagePickedUp = false;
	public GameObject BigQues1t;
	public Text MainQuest;
	public Text SubQuest;
	public Text BigQuest;
	public bool slimetargetet = false;
	public GameObject mm1;
	public GameObject mm2;
	public GameObject mm12;
	public GameObject tst;
	public GameObject exclamation;
	public GameObject trigger;
	public GameObject zelka;
	//public GameObject pointlightzaferma;
	public GameObject cubezaferma;
	public GameObject predishencub;
	public GameObject tab;
	public GameObject rainstorm;
	public GameObject fire;
	// Use this for initialization
	public bool govorqsivan;

	void Start ()
	{
		govorqsivan = false;
	}

	public void OK1 ()
	{
		BigQues1t.SetActive (false);
		//pointlightzaferma.SetActive (true);
		cubezaferma.SetActive (true);
		predishencub.SetActive (false);
	}

	// Update is called once per frame
	void Update ()
	{
		if (tst.activeSelf == true) {
			if (GameObject.Find ("Enemy/Slime (2)") != null) {
				if (tst.GetComponent<MauseSelecting> ().Thetarget == GameObject.Find ("Enemy/Slime (2)")) {

					MainQuest.text = "Play the FIRE SONG";
					SubQuest.text = "play the notes below";
					mm1.GetComponent<CanvasGroup> ().alpha = 0;
					mm2.GetComponent<CanvasGroup> ().alpha = 0;
					mm12.GetComponent<CanvasGroup> ().alpha = 0;
				}
			}
		}

		if (GameObject.Find ("Enemy/Slime (2)") == null) {
			if (CabbagePickedUp == true && govorqsivan == false) {
				MainQuest.text = "Return the cabbage";
				SubQuest.text = "Find the 'FARMER'";
				mm2.GetComponent<CanvasGroup> ().alpha = 0;
				exclamation.SetActive (true);
				if (trigger.GetComponent<triggered> ().isstay) {

					if (Input.GetMouseButtonDown (1)) {

						RaycastHit hit;

						Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
						if (Physics.Raycast (ray, out hit)) {
							if (hit.collider.name == "NPC1") {
								zelka.SetActive (true);
								govorqsivan = true;
								MainQuest.text = "Play the Rain song";
								SubQuest.text = "Go to the garden";
								BigQues1t.SetActive (true);
								//Debug.Log("asdf");


							}
						}

					}

				}
			} else if (govorqsivan == false) {

				MainQuest.text = "PICK UP THE CABBAGE";
				SubQuest.text = "M2= pick up";
				mm2.GetComponent<CanvasGroup> ().alpha = 1;
			}
			if (govorqsivan == true && cubezaferma.GetComponent<triggered> ().isstay) {
				tab.SetActive (true);
				if (tab.GetComponent<tab> ().rainsong) {
					rainstorm.SetActive (true);
					fire.SetActive (false);
					tab.SetActive (false);
					predishencub.SetActive (true);
					cubezaferma.SetActive (false);
					MainQuest.text = "Well Done";
					SubQuest.text = "Return to the farmer";
                    
					if (predishencub.GetComponent<triggered> ().isstay) {

						if (Input.GetMouseButtonDown (1)) {

							RaycastHit hit;

							Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
							if (Physics.Raycast (ray, out hit)) {
								if (hit.collider.name == "NPC1") {

									
									BigQues1t.SetActive (true);
									BigQuest.text = "takash torba gomba gomba gomba";
									exclamation.SetActive (false);
                                    MainQuest.text = "gj m8";
                                    SubQuest.text = "you can now kill goombas";
                                }
							}
						}
					}
				}
			}
			if (govorqsivan == true && cubezaferma.GetComponent<triggered> ().isstay == false) {
				tab.SetActive (false);
			}
			if (Input.GetMouseButtonDown (1)) {

				RaycastHit hit;

				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				if (Physics.Raycast (ray, out hit)) {
					if (hit.collider.tag == "equipment") {
						Debug.Log ("DA");
						CabbagePickedUp = true;
						cabbage.SetActive (false);

					} else {
						return;
					}

				}
			}
		}
	}
    
}

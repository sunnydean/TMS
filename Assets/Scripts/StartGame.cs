using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour
{

	// Use this for initialization
	public void ChangeToScene (int sceneToChangeTo)
	{
		Application.LoadLevel (sceneToChangeTo);
	}
}
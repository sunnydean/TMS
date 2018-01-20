using UnityEngine;
using System.Collections;

public class HIDEUNHIDE : MonoBehaviour {
    public GameObject loni;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (loni.activeSelf)
        {
            if (Input.GetKeyDown("p"))
            {
                loni.SetActive(false);
            }
        }
        else
        {
            if (Input.GetKeyDown("p"))
            {
                loni.SetActive(true);
            }
        }
	}
}

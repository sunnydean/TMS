using UnityEngine;
using System.Collections;

public class triggered : MonoBehaviour {
    public bool isstay;
  
	// Use this for initialization
	void Start () {
        isstay = false;
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name== "davetest" ) {
            isstay = true;
        }
	}
    void OnTriggerExit(Collider col) {
        if (col.gameObject.name == "davetest")
        {
            isstay = false;
        }
    }
}

using UnityEngine;
using System.Collections;

public class offsetscript : MonoBehaviour
{
	public Renderer rend;
	float offsetvalue = 0.05f;
	// Use this for initialization
	void Start ()
	{
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		float offset = Time.time * offsetvalue;
		rend.material.SetTextureOffset ("_MainTex", new Vector2 (offset, 0));

	}
}

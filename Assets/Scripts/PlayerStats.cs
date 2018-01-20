using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{
	public static int PlayerHP = 200;
	public static int CurrentPlayerHP;
	public static string PlayerName;


	// Use this for initialization
	void Start ()
	{
		CurrentPlayerHP = PlayerHP;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

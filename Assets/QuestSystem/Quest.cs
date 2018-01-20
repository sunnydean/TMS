using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Quest
{
	public string giver;
	public string title;
	public string text;
	public int goldReward;
	public Transform scriptObj;
	public bool completed;

	public Quest (string _giver, string _title, string _text, int _goldReward, Transform _scriptObj, bool _completed)
	{
		giver = _giver;
		title = _title;
		text = _text;
		scriptObj = _scriptObj;
		goldReward = _goldReward;
	}
}
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testclick : MonoBehaviour
{

	// Use this for initialization
	void Start () 
	{

		Button btn = gameObject.GetComponent<Button>();
//		btn.onClick.AddListener(click);
	}

	void click()
	{
		Debug.Log (" UI Mouse Click");
	}
}

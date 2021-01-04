using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class buttonClick : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Button btn = gameObject.GetComponent<Button>();
		//btn.onClick+=click();

		btn.onClick.AddListener(
			delegate()
			{
				for(int i=0;i<10;i++)
				{
					onClick(i);
				}
			});
	}

	public void onClick(int index)
	{
		Debug.Log (index);
	}
}

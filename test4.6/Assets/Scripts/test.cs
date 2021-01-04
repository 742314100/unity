using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.UI;

public class test : MonoBehaviour {

	void Start ()
	{
//		//定义Action，并赋予delegate方法
//		UnityAction<Button> btnActions = new UnityAction<Button>(onClick);
//		//找到Button控件，并订阅事件
//		Button btn = gameObject.GetComponent<Button>();
//		btn.onClick.AddListener(btnActions);



	}
	
	void onClick()
	{
		Debug.Log("button===========");
		Debug.Log("11111111");
	}
	void Click1()
	{
		Debug.Log("22222222");
	}
}


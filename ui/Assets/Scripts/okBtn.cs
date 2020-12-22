using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class okBtn : MonoBehaviour,IPointerDownHandler,IPointerUpHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("down");
        transform.localScale = new Vector3(1, 1, 1);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("up");
        transform.localScale = new Vector3(1.2f,1.2f,1.2f);
    }
}

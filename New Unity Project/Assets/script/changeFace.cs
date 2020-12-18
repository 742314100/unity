using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeFace : MonoBehaviour {

    public Sprite sprite0;
    public Sprite sprite1;

    private int index = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
            DoChange();
        }
	}

    void DoChange()
    { 
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        if (index == 0)
        {
            index = 1;
            renderer.sprite = this.sprite1;
        }
        else 
        {
            index = 0;
            renderer.sprite = this.sprite0;
        }

    }
}

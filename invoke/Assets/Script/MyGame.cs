using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGame : MonoBehaviour {

    public int score = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddScore(int value)
    {
        this.score += value;
        Debug.Log("得分+1，当前总分="+score);
    }

}

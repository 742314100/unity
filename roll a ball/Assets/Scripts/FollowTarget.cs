using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {

    public Transform playerTransform;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - playerTransform.position; //摄像机位移-玩家位移

	}
	
	// Update is called once per frame
	void Update () {
        transform.position = playerTransform.position + offset; //给当前相机位置赋值，可以跟随玩家
	}
}

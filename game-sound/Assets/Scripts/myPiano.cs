using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPiano : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            //判断鼠标是否点中当前物体
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            float distance = (mousePos - transform.position).magnitude;
            if(distance < 2)
            {
                //取得AudioSource
                AudioSource audio = GetComponent<AudioSource>();

                if (audio.isPlaying)
                {
                    audio.Stop();
                }
                else {
                    audio.Play();
                }

            }
        }
	}
}

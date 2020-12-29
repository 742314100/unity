using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebWork : MonoBehaviour {

    private string url = "https://api.apiopen.top/getJoke?page=1&count=2&type=video";

    public Text dataText;
    public Text dataText1;

	// Use this for initialization
	IEnumerator Start () {
        WWW getData = new WWW(url);  //get 方法
        yield return getData;
        if (getData.error != null)
        {
            Debug.Log(getData.error);
        }
        else {
            Debug.Log(getData.text);
            dataText.text = getData.text;
        }

	}

    //post 方法

    IEnumerator ToPost()
    {
        WWWForm form = new WWWForm();
        form.AddField("userid","ABC");
        form.AddField("pwd","***");
        WWW getData = new WWW(url,form);
        yield return getData;
        if (getData.error != null)
        {
            Debug.Log(getData.error);
        }
        else 
        {
            Debug.Log(getData.text);
            dataText1.text = getData.text;
        }

    }

	
	// Update is called once per frame
	void Update () {
		
	}
}

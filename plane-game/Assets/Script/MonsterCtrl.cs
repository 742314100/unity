using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour {

    public GameObject monsterPrefab;

    public Sprite[] image;

	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateMonster",0.1f,2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateMonster()
    {
        float x = Random.Range(-2,2);
        float y = 5;
        GameObject monster = Instantiate(monsterPrefab);
        monster.transform.position = new Vector3(x,y,0);

        //随机选择一个怪物头像
        int index = Random.Range(0,image.Length);
        SpriteRenderer render = monster.GetComponent<SpriteRenderer>();
        render.sprite = this.image[index];

        //头像的大小设为100px
        Sprite sprite = this.image[index];
        float imgWidth = sprite.rect.width; //图像的实际宽度
        float scale = 100 / imgWidth; //缩放比例
        monster.transform.localScale = new Vector3(scale,scale,scale);

    }

}

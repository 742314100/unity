using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl : BaseObj {

    private Vector3 primitivePos;
    private Vector3 primitiveRot;
    private Vector3 temPos;
    private bool canMove;

    private Vector3 targetPos;
    private float distance;

    public bool GetMove
    {
        set { canMove = value; }
        get { return canMove; }
    }

	// Use this for initialization
	void Start () {
        distance = 1;
        canMove = false;
        primitivePos = transform.position;
        primitiveRot = transform.eulerAngles;
        temPos = Vector3.zero;
        targetPos = new Vector3(-4,0.5f,0);
	}
	
	// Update is called once per frame
	void Update () {
		if(canMove)
        {
            MoveTo(targetPos, distance);
        }
	}

    protected override void MoveTo(Vector3 go, float dis)
    {
        if (Vector3.Distance(transform.position, go) > dis)
        {
            temPos = go;
            temPos.y = transform.position.y;
            transform.LookAt(temPos);
            transform.Translate(Vector3.forward * Time.deltaTime * 5);
        }
        else 
        {
            canMove = false;
            if(dis > 0.1f)
            {
            //攻击

                //返回阶段的参数变化
                GoBackParameter();
            }
            else
            {
            //返回原始位置
                GoBack();
            }
        }
    }

    private void GoBack()
    {
        transform.position = primitivePos;
        transform.eulerAngles = primitiveRot;
        canMove = false;
    }

    private void GoBackParameter()
    {
        canMove = true;
        targetPos = primitivePos;
        distance = 0.1f;
    }

    private void ChangeNext
    { 
    
    }

}

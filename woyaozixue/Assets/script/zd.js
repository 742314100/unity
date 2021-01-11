#pragma strict

function Start () {
	
}

var speed : int = 5;

function Update () {
    var x : float = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
    var y : float = Input.GetAxis("Vertical")*Time.deltaTime*speed;
    transform.Translate(x,0,y);
}

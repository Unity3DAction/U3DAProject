var x;
var y;
var z;
var pos;

function Start () 
{
	x = Random.Range(-25, 26);
    y = 5;
    z = Random.Range(-25, 26);
   	pos = new Vector3(x, y, z);
    transform.position = pos;
}


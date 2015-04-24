//pragma strict

var TheDammage : int = 50;
var Distance   : float;
var MaxDistance: float = 1.5;
var TheSystem  : Transform ;

function Update ()
{
	// if(Input.GetButtonDown("Fire1"))
	// {
	// 	/*Attack animation*/
	// 	TheSystem.animation.Play("Attack");
	// }
	// if(TheSystem.animation.isPlaying == false)
	// {
	// 	TheSystem.animation.CrossFade("Idle");
	// }

	// if(Input.GetKey(KeyCode.LeftShift))
	// {
	// 	TheSystem.animation.CrossFade("Sprint");
	// }

	// if(Input.GetKeyUp(KeyCode.LeftShift))
	// {
	// 	TheSystem.animation.CrossFade("Idle");
	// }

}
function AttackDamage()
{
	/*Attack function*/
	var hit : RaycastHit;
	//Raycast　仮想上の線を出し、衝突判定をとる
	//第一引数にはレイキャストの原点の位置、第二引数は方向、第三引数には衝突情報、第四引数には検知を行う距離、第五引数にはレイヤーマスクをとる
	if(Physics.Raycast (TheSystem.transform.position, TheSystem.transform.TransformDirection(Vector3.forward), hit))
	{
		Distance = hit.distance;
		if(Distance < MaxDistance)
		{
			hit.transform.SendMessage("ApplyDammage", TheDammage, SendMessageOptions.DontRequireReceiver);
		}
	}
}
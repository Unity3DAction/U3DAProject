var currentDistance; //現在のプレイヤーとの距離
var beforeDistance;
var Target : Transform;
// var lookAtDistance = 25.0; //視界範囲内の距離
var chaseRange = 15.0;
var attackRange = 3;
var moveSpeed = 5.0;
var Damping = 6.0;

var isChasingPlayer:boolean = false;

// var aPlayer : GameObject;
var hadMovePlayer:boolean = false;
// var beforePlayerPosition;
var currentPlayerPosition;

// function Start ()
// {
// 	aPlayer = GameObject.Find("First Person Controller");

// }
function Update () 
{

	lookAt();

	//プレイヤーが動いたか判定する
	currentPlayerPosition = Target.position;
	currentDistance = Vector3.Distance(currentPlayerPosition, transform.position);


	if(CheckMovingPlayer() == true)
	{
		hadMovePlayer = true;
		isChasingPlayer = true;
	}
	if(hadMovePlayer)
	{
			if (currentDistance < attackRange) 
			{
				attack();
				isChasingPlyer = false;
			}
			else if (isChasingPlayer)//fuckin' if-construct
			{
				chase();
			}

	}

}

function lookAt ()
{
	var rotation = Quaternion.LookRotation(Target.position - transform.position);
	//y軸しか回転しないので、それ以外の軸０
	rotation.x = 0.0;
	rotation.z = 0.0;

	transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping);
}

function chase () 
{
	transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	// adjustPosition();
}

function attack() 
{
	var camera = Target.FindChild("Main Camera").gameObject;
	camera.SendMessage("changeGameOver", SendMessageOptions.DontRequireReceiver);
}

function adjustPosition() 
{
	transform.rotation.y = 2.19;
	Debug.Log(transform.rotation.y);
}

function CheckMovingPlayer ()
{
	if(currentPlayerPosition.x >= 1 || currentPlayerPosition.x <= -1 ||
		currentPlayerPosition.z >= 1 || currentPlayerPosition.z <= -1)
	{
		return true;
	}
	else
	{
		return false;
	}
}
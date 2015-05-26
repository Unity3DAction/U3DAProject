var Distance; //実際の距離
var Target : Transform;
// var lookAtDistance = 25.0; //視界範囲内の距離
var chaseRange = 15.0;
var attackRange = 3;
var moveSpeed = 5.0;
var Damping = 6.0;


function Update () 
{
	Distance = Vector3.Distance(Target.position, transform.position);

	lookAt();
	
	if (Distance < attackRange) 
	{
		Debug.Log("change in GAME OVER State");
		attack();
	}
	else if (Distance < chaseRange)
	{
		Debug.Log("Chase!!");
		chase();
	}
}

function lookAt ()
{
	var rotation = Quaternion.LookRotation(Target.position - transform.position);
	transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * Damping);
}

function chase () 
{
	transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
}

function attack() 
{
		
}

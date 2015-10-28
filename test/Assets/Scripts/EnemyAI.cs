using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour 
{
	private float currentDistance;
	private float beforeDistance;
	public Transform target;
	private GameState aGameState;

	private float chaseRange = 15.0f;
	private float attackRange = 3.0f;
	private float moveSpeed = 3.5f;
	private float damping = 6.0f;

	private bool isChasingPlayer = false;

	private bool hadMovePlayer = false;
	private Vector3 currentPlayerPosition;

	// Use this for initialization
	void Start () 
	{
		aGameState = target.GetComponent<GameState>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		lookAt();

		currentPlayerPosition = target.position;
		currentDistance = Vector3.Distance(currentPlayerPosition, transform.position);

		if(CheckMovingPlayer())
		{
			hadMovePlayer = true;
			isChasingPlayer = true;
		}
		// if(!aGameState.getOnClearGame())
		// {
			if(hadMovePlayer)
			{
				if(currentDistance < attackRange)
				{
					attack();
					isChasingPlayer = false;
				}else if (isChasingPlayer)
				{
					chase();
				}
			}
		// }
	}

	private void lookAt()
	{
		Quaternion rotation = Quaternion.LookRotation(target.position - transform.position);

		//y軸しか回転しないので、それ以外の軸０
		rotation.x = 0.0f;
		rotation.z = 0.0f;

		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
	}

	private void chase()
	{
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}

	private void attack()
	{
		GameObject camera = target.FindChild("Main Camera").gameObject;
		camera.SendMessage("changeGameOver", SendMessageOptions.DontRequireReceiver);
	}

	// private void adjustPosition()
	// {
		
	// }

	private bool CheckMovingPlayer()
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
}

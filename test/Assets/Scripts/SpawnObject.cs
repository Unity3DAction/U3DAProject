using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour 
{
	private bool isCollision = false;
	private bool onGround = false;
	// Use this for initialization
	void Start () 
	{
		this.Spawn();
	}

	void Update ()
	{
		if(isCollision)
		{
			if(!onGround)
			{
				this.Spawn();
				isCollision = false;
			}
		}
	}

	private void OnTriggerEnter(Collider aCollider)
	{
		isCollision = true;
		if(aCollider.gameObject.CompareTag("Terrain"))
		{
			onGround = true;
		}
		// else
		// {
		// 	onGround = false;
		// }
	}

	private void Spawn()
	{
		float x = Random.Range(-45, 45);
		float y = 5f;
		float z = Random.Range(-63, 23);
		Vector3 pos = new Vector3(x, y, z);
		transform.position = pos;

		rigidbody.velocity = new Vector3(0,0,0);

	}

}

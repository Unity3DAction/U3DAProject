using UnityEngine;
using System.Collections;

public class EnemyMoveScript : MonoBehaviour {

	public Transform player;
	public float speed = 3;
	

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 playerPosition = player.position;
		Vector3 direction = playerPosition - transform.position;//方向
		direction = direction.normalized;//単位方向

		//Enemyの位置要素xyzを取るために、一旦変数に束縛
		var movePosition = transform.position + (direction * speed * Time.deltaTime);
		//y軸方向は一定
		transform.position = new Vector3(
			movePosition.x,
			2,
			movePosition.z);

		transform.LookAt(2*transform.position - playerPosition);//元モデルの角度により反転
	
	}
}

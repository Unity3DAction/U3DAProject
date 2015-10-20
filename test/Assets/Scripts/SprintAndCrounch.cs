using UnityEngine;
using System.Collections;

public class SprintAndCrounch : MonoBehaviour {
	public float walkSpeed = 7;
	public float crounchSpeed = 3;
	public float sprintSpeed = 13;
	
	// private CharacterMotor aCharacterMotor;
	private CharacterController aCharacterController;
	private Transform theTransform;
	private float aCharacterHeight;
	
	// Use this for initialization
	void Start () 
	{
		//  aCharacterMotor = GetComponent<CharacterMotor>();
		// theTransform = transform;
		// aCharacterHeight = aCharacterController.height/2;
	}		
	
	// Update is called once per frame
	void Update () {
		// float currentHeight = CharacterController;
		// float speed = walkSpeed;
		
		// if((Input.GetKey("left shift") || Input.GetKey("right shift"))
		// 	&& aCharacterController.isGrounded)
		// {
		// 	speed = sprintSpeed;
		// }
		
		// if (Input.GetKey("c"))
		// {
		// 	currentHeight = aCharacterHeight * 0.5f;
		// 	speed = crounchSpeed;	
		// }
		
		// aCharacterMotor.movement.maxForwardSpeed = speed;
		// float lastHeight = aCharacterController.height;
		// aCharacterController.height = 
		// 	Mathf.Lerp(aCharacterController.height, currentHeight,5*Time.deltaTime);
		// theTransform.position.y += (aCharacterController.height-lastHeight)/2;
		
	}
}

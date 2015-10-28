using UnityEngine;
using System.Collections;

public class PianoLogic : MonoBehaviour {

	private string theCollider;
	private GameObject aPiano;


	void Start()
	{
		aPiano = gameObject.transform.parent.gameObject;
	}

	void OnTriggerEnter(Collider other)
	{
		theCollider = other.tag;
		if(theCollider == "Player")
		{
			if(!audio.isPlaying)
			{
				Debug.Log("I hear this pianos harmony!!!");
				audio.Play();
			}
			// AudioSource.PlayClipAtPoint(pianosHarmony, aPiano.transform.position);
			

		}
	}
}

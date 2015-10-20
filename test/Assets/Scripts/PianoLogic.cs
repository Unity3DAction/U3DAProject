using UnityEngine;
using System.Collections;

public class PianoLogic : MonoBehaviour {

	public AudioClip pianosHarmony;

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
			Debug.Log("I hear this pianos harmony!!!");
			AudioSource.PlayClipAtPoint(pianosHarmony, aPiano.transform.position);
			// AudioSource.PlayClipAtPoint(miSound, aPiano.transform.position);
			// AudioSource.PlayClipAtPoint(soSound, aPiano.transform.position);

		}
	}
}

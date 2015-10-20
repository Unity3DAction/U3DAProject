using UnityEngine;
using System.Collections;

public class AudioZone : MonoBehaviour 
{
	private string theCollider;

	void OnTriggerEnter(Collider other)
	{
		theCollider = other.tag;
		if(theCollider == "Player")
		{
			audio.Play();
			audio.loop = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		theCollider = other.tag;
		if(theCollider == "Player")
		{
			audio.Stop();
			audio.loop = false;
		}
	}

}

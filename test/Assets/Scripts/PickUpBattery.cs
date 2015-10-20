using UnityEngine;
using System.Collections;

//fuckin' code!
//Player must have this class.
public class PickUpBattery : MonoBehaviour 
{

	public bool inBatteryRange;
	public bool buttonActivated;
	public AudioClip batterySound;
	private static float batteryPower = 10;

	public GUISkin guiSkin;
	private bool hasPlayed = false;

	private GameObject aFlashlight;
	private ReFlashlight aReFlashlight;

	void Start ()
	{
		aFlashlight = GameObject.Find("FlashLight");
		aReFlashlight = aFlashlight.GetComponent<ReFlashlight>();
	}
	private void OnTriggerEnter(Collider aCollider)
	{
		Debug.Log("Something collision !");
		if(aCollider.gameObject.CompareTag("Player"))
		{
			Debug.Log("It is Battery !!");
			inBatteryRange = true;
		}
	}
	private void OnTriggerExit(Collider aCollider)
	{
		if(aCollider.gameObject.CompareTag("Player"))
		{
			inBatteryRange = false;
		}
	}
	void OnGUI()
	{
		if(inBatteryRange)
		{
			GUI.skin = guiSkin;
			GUI.Label(new Rect(Screen.width/2-50,Screen.height/2-55,120,50), "Pick up batteries");
		}
		else
		{
			GUI.skin = null;
		}
	}
	// Update is called once per frame
	void Update () 
	{
		if(inBatteryRange)
		{
			if(Input.GetKeyDown("e"))
			{
				if(!hasPlayed)
				{
					AudioSource.PlayClipAtPoint(batterySound, transform.position);
					aReFlashlight.AlterEnergy(batteryPower);
					Destroy(gameObject);
					hasPlayed = true;
				}
			}
		}
	}
}

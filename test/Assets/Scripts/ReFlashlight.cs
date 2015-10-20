using UnityEngine;
using System.Collections;

//コンポーネント自動追加（オーディオソース）
[RequireComponent(typeof(AudioSource))]
public class ReFlashlight : MonoBehaviour 
{
	public GameObject aSpotLight;
	public bool lightOn = true;
	public float lightDrain = 0.07f; 
	public float batteryLife = 0.0f;
	public float maxBatteryLife = 5.0f;

	private static float batteryPower = 2.5f;

	public AudioClip soundSwitchingLight;
	//public AudioClip soundTurnOff;

	// Use this for initialization
	void Start () 
	{
		batteryLife = maxBatteryLife;
		aSpotLight = transform.FindChild("Spotlight").gameObject;
	}

	public void AlterEnergy(float amount)
	{
		batteryLife = Mathf.Clamp(batteryLife + batteryPower, 0, 100);
	}
	// Update is called once per frame
	void Update () 
	{
		//ライトつけっぱなしの状態
		if(lightOn && batteryLife >= 0)
		{
			batteryLife -= Time.deltaTime * lightDrain;
		}

		aSpotLight.light.intensity = batteryLife;

		if(batteryLife <= 0)
		{
			batteryLife = 0;
			lightOn = false;
		}


		if(Input.GetKeyUp(KeyCode.Mouse1))
		{

			if(lightOn)
			{
				lightOn = false;
			}
			else if(!lightOn && batteryLife >= 0)
			{
				lightOn = true;
			}
			toggleFlashlight();
			toggleFlashlightSFX();
		}

	}

	void toggleFlashlight()
	{
		if(lightOn)
		{
			aSpotLight.light.enabled = true;
		}
		else
		{
			aSpotLight.light.enabled = false;
		}
	}

	void toggleFlashlightSFX()
	{
		Debug.Log("Sound it !!");
		AudioSource.PlayClipAtPoint(soundSwitchingLight, transform.position);
	}
}

var switchingSound : AudioClip;

private var aSpotLight : GameObject;

function Start() 
{
	aSpotLight = transform.FindChild("Spotlight").gameObject;
}
function Update () 
{
	//右クリック
	if (Input.GetKeyDown(KeyCode.Mouse1)) 
	{
		if (aSpotLight.light.enabled == false)
		{
			aSpotLight.light.enabled = true;
		}
		else
		{
			aSpotLight.light.enabled = false;
		}
		AudioSource.PlayClipAtPoint(switchingSound, transform.position);
	}
}
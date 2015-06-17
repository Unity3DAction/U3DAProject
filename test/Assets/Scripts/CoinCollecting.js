var collectingCoins = 0;
var collectSound : AudioClip;

function OnTriggerEnter( other : Collider ) 
{
	if(other.tag == "Coin")
	{
		collectingCoins++;
		AudioSource.PlayClipAtPoint(collectSound, transform.position);
		Destroy(other.gameObject);
	}	
}

function OnGUI() 
{
	GUILayout.Label( "Coin : " + collectingCoins );	
}
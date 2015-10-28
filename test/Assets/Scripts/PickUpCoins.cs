using UnityEngine;
using System.Collections;

public class PickUpCoins : MonoBehaviour {

	private int collectingCoins = 0;
	public AudioClip collectingSound;

	//private SpawnCoins aSpawnCoins;

	void Start()
	{
		// aSpawnCoins = gameObject.GetComponent<SpawnCoins>();
	}
	// Use this for initialization
	void OnTriggerEnter (Collider other) 
	{
		//コインが地面に落ちている時に取得
		if(other.tag == "Coin" && other.transform.position.y <= 0.5f)
		{
			collectingCoins++;
			AudioSource.PlayClipAtPoint(collectingSound, transform.position);
			Destroy(other.gameObject);
		}
	}
	
	// Update is called once per frame
	void OnGUI () 
	{
		GUILayout.Label(" Coin : " + collectingCoins);
	}

	public int getCollectingCoins()
	{
		return collectingCoins;
	}

}

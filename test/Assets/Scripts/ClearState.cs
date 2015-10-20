using UnityEngine;
using System.Collections;

public class ClearState : MonoBehaviour {

	public GameObject parentObject;
	private PickUpCoins aCoinCollecting;
	private bool onClearGame = false;

	private GameObject canvasObject;

	// Use this for initialization
	void Start () 
	{
		parentObject = gameObject.transform.parent.gameObject;
		if(canvasObject == null)
		{
			canvasObject = GameObject.Find("Canvas");
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Debug.Log(parentObject);
		int collectingCoins = parentObject.GetComponent<PickUpCoins>().getCollectingCoins();
		if(collectingCoins >= 8)
		{
			onClearGame = true;
		}
		ConvertCanvasActibity();
		// Debug.Log("CLEAR !!!!");
	}

	private void ConvertCanvasActibity()
	{
		if(onClearGame)
		{
			canvasObject.SetActive(true);
		}
		else
		{
			canvasObject.SetActive(false);
		}

	}


}

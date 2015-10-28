using UnityEngine;
using System.Collections;

//ゲームクリア状態の処理を行うクラス
public class ClearState : MonoBehaviour 
{
	//プレイヤーのゲームオブジェクト
	public GameObject player;
	//ゲームの状態を保持
	private GameState aGameState;
	//キャンパスオブジェクトを保持
	private GameObject canvasObject;


	//GameStateクラスを保持、キャンバスobjを探し保持
	void Start () 
	{
		player = gameObject.transform.parent.gameObject;
		aGameState = player.GetComponent<GameState>();
		if(canvasObject == null)
		{
			canvasObject = GameObject.Find("Canvas");
		}
	}
	
	
	// 集めたコインがクリア判定に超えてるかを判定し、
	// 超えていたらクリア状態にする。
	void Update () 
	{
		int collectingCoins = player.GetComponent<PickUpCoins>().getCollectingCoins();
		if(collectingCoins >= 8)
		{
			aGameState.setOnClearGame(true);
		}

		ConvertCanvasActibity();
	}

	//クリア状態ならキャンパスをアクティブに、そうでなければ非アクティブに
	private void ConvertCanvasActibity()
	{
		if(aGameState.getOnClearGame())
		{
			canvasObject.SetActive(true);
		}
		else
		{
			canvasObject.SetActive(false);
		}

	}


}

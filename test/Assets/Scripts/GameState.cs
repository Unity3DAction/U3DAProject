using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour 
{

	public bool onClearGame = false;

	// public static GameManager instance = null;

	// void Awake ()
	// {
	// 	//シングルトンパターンーManagerは唯一な存在なので、２つ以上存在したらこれは消滅する。
	// 	if(instance == null)
	// 	{
	// 		instance = this;
	// 	}else if (instance != this)
	// 	{
	// 		Destroy(gameObject);
	// 	}

	// 	//シーンをリロードするときに壊されないようにする
	// 	DontDestroyOnLoad(gameObject);
	// }
	// Use this for initialization
	void Start () 
	{
		if(onClearGame)
			onClearGame = false;
	}

	void Update ()
	{
		if(onClearGame)
		{
			Time.timeScale = 0;
		}
	}
	public bool getOnClearGame()
	{
		return onClearGame;
	}
	
	public void setOnClearGame(bool onClearGame)
	{
		this.onClearGame = onClearGame;
	}

}

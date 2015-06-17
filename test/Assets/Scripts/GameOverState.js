var style: GUIStyle;
var onGameOver: boolean = false;

var player: GameObject;

var labelWidth : int;
var labelHeight : int;
var buttonWidth : int;
var buttonHeight : int;

// GUIでゲーム上で文列を表示
function OnGUI () 
{
	if (onGameOver == true)
	{
		var labelRect = Rect( 
			Screen.width / 2 - (labelWidth / 2),
			(2 * Screen.height / 3) - (labelHeight / 2),
         	 labelWidth,
         	 labelHeight ); 			  
		GUI.Label(labelRect,
			/*Rect(Screen.width * 0.5 - 51,200,102,22)*/
			"Game Over", style);
		
		var buttonRect = Rect(
          Screen.width / 2 - (buttonWidth / 2),
          (2 * Screen.height / 3) - (buttonHeight / 2),
          buttonWidth,
          buttonHeight );
		var aButton = GUI.Button(buttonRect,
		/*Rect(Screen.width * 0.5-20,300,102,22),*/
		 "タイトルに戻る");
		 
		if(aButton)
		{
			Debug.Log("Button Pushed!!");
			Application.LoadLevel("3DTitle");
		}
		
		//プレイヤーを動けなくする
		var aState = player.GetComponent("ControllerState");
		aState.switchingToOff();
	}
}

//ゲームオーバー状態に変更
function changeGameOver()
{
	onGameOver = true;
}

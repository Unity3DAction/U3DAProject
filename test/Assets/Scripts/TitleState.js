﻿//GUIのスタイル
var style: GUIStyle;

//ボタンサイズ
var buttonWidth : int;
var buttonHeight : int;

//GUIでゲーム上で文列、ゲームスタートボタンを表示
//配置のズレが起きるので、uGUIを入れる必要がある。
function OnGUI () 
{
	var buttonRect = Rect(
  	      Screen.width / 2 - (buttonWidth / 2),
          (2 * Screen.height / 3) - (buttonHeight / 2),
          buttonWidth,
          buttonHeight );
	var aButton = GUI.Button(buttonRect,
		/*Rect(Screen.width * 0.5-20,300,102,22),*/
		 "Game Start");
		 
	if(aButton)
	{
		Application.LoadLevel("test");
	}
	
}

var style: GUIStyle;

var buttonWidth : int;
var buttonHeight : int;

// GUIでゲーム上で文列を表示
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
		Debug.Log("Title Button Pushed!!");
		Application.LoadLevel("test");
	}
	
}

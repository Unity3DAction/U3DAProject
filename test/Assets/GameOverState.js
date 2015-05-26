var style: GUIStyle;
private var drawGUI = false;

function Update () 
{
	//style.fontSize = 30; 
	// style.normal.textColor = Color.magenta;
}

// // トリガー判定に入った場合の処理
// function OnTriggerEnter(theCollider : Collider)
// {
// 	if (theCollider.tag == "Player") 
// 	{
// 		drawGUI = true;
// 		// Debug.Log("Working");
// 	}
// }



// GUIでゲーム上でコメント化
function OnGUI () 
{
	if (drawGUI == true) 
	{
		GUI.Label(Rect(Screen.width * 0.5 - 51,200,102,22), "Game Over", style);
	}
}

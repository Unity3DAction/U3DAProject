using UnityEngine;
using System.Collections;

//uGUIのボタンとリンクしてコントロールするクラス
public class BottonController : MonoBehaviour
{
	//uGUIのボタンをクリックすると、タイトルをロード
	public void ClickButton()
	{
		Application.LoadLevel("3DTitle");
	}

}

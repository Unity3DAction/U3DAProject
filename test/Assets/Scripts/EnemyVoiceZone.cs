using UnityEngine;
using System.Collections;


//追跡者のAudioSourceの聞こえる判定をコントロール
public class EnemyVoiceZone : MonoBehaviour 
{
	//衝突物のstring
	private string theCollider;

	//プレイヤーが衝突判定に入った時追跡者のaudioを鳴らす
	void OnTriggerEnter(Collider other)
	{
		theCollider = other.tag;
		if(theCollider == "Player")
		{
			audio.Play();
			audio.loop = true;
		}
	}

	//プレイヤーが衝突判定エリアから抜けた時追跡者のaudioを止める
	void OnTriggerExit(Collider other)
	{
		theCollider = other.tag;
		if(theCollider == "Player")
		{
			audio.Stop();
			audio.loop = false;
		}
	}

}


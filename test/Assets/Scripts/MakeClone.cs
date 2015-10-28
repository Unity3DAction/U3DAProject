using UnityEngine;
using System.Collections;

public class MakeClone : MonoBehaviour {

	public GameObject theObject;
	public int objectNumber;

	void Start () 
	{	
		for(int i = 0;i < objectNumber; i++)
		{
			GameObject anObject = Instantiate(theObject)as GameObject;
			anObject.transform.parent = this.transform;
		}
	}
	
}

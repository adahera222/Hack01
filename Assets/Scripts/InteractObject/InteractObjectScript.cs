using UnityEngine;
using System.Collections;

public class InteractObjectScript : MonoBehaviour {
	
	public string displayName = "Object";
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	

	//-------------------------------------------------------
	public void _OnEnter(){
		Debug.Log("Mouse Enter "+displayName);
		
		BroadcastMessage("OnEnter", SendMessageOptions.DontRequireReceiver);		
	}
	
	public void _OnExit(){	
		Debug.Log("Mouse Exit "+displayName);
		
		BroadcastMessage("OnExit", SendMessageOptions.DontRequireReceiver);
	} 
	
	public void _OnClick(){
		Debug.Log("Mouse Click "+displayName);
		
		BroadcastMessage("OnClick", SendMessageOptions.DontRequireReceiver);
	}
	
	
	
}

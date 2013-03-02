using UnityEngine;
using System.Collections;

public class I_Test : MonoBehaviour {
	
	public GameObject obj;
	
	// Use this for initialization
	void Start () {
		obj.active = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnEnter() {
		Debug.Log("YOP YOP YOP");
		obj.active = true;
	}
	
	void OnExit() {
		Debug.Log("CIAO !!!");
		obj.active = false;
	}
}

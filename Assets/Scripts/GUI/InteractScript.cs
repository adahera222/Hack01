using UnityEngine;
using System.Collections;

public class InteractScript : MonoBehaviour {
	
	private CrossHairScript crossHairScript;
	
	public float maxDistance = 5;
	public InteractObjectScript target;
	//public string interactMethod = "Interact";
	
	// Use this for initialization
	void Start () {
		crossHairScript = GetComponent<CrossHairScript>();
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width*0.5f, Screen.height*0.5f));
		
		//target = null;
		//crossHairScript.current = 0;
		
		bool found = false;
		if (Physics.Raycast(ray, out hit, maxDistance)) {
			GameObject obj = hit.collider.gameObject;			
			InteractObjectScript interact = obj.GetComponent<InteractObjectScript>();
			if (interact){
				found = true;
				if(target != interact){
					if(target) target._OnExit();
					target = interact;
					target._OnEnter();
				}
				
			
				//crossHairScript.current = 1;
				crossHairScript.setCursor("over");
				
				if(Input.GetMouseButtonDown(0)){
					//target.BroadcastMessage(interactMethod, null, SendMessageOptions.DontRequireReceiver);
					target._OnClick();
				}
			}
		}
		
		if(!found){
			if(target){
				target._OnExit();
				target = null;
				
				crossHairScript.current = 0;
			}
		}
	}
}

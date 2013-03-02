using UnityEngine;
using System.Collections;

public class InteractScript : MonoBehaviour {
	
	private CrossHairScript crossHairScript;
	
	public GameObject target;
	public string interactMethod = "Interact";
	
	// Use this for initialization
	void Start () {
		crossHairScript = GetComponent<CrossHairScript>();
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width*0.5f, Screen.height*0.5f));
		
		target = null;
		crossHairScript.current = 0;
		
		if (Physics.Raycast(ray, out hit)) {
			target = hit.collider.gameObject;			
			InteractObjectScript interactObject = target.GetComponent<InteractObjectScript>();
			if (interactObject){
			
				crossHairScript.current = 1;	
				if(Input.GetMouseButton(0)){
					target.BroadcastMessage(interactMethod, null, SendMessageOptions.DontRequireReceiver);
				}
			}
		}
	}
}

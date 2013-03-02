using UnityEngine;
using System.Collections;

public class CrossHairScript : MonoBehaviour {
	
	public Texture[] textures;
	public int current;
	
	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
		Screen.lockCursor = true;
	}
	
	void Update(){
		Screen.lockCursor = true;
	}
	
	void OnGUI() {
		if(current == -1) return;
		
		Texture texture = textures[current];
		GUI.DrawTexture(
			new Rect(
				(Screen.width - texture.width)*0.5f,
				(Screen.height - texture.height)*0.5f,
				texture.width, 
				texture.height
			), 
			texture
		);
	}
}

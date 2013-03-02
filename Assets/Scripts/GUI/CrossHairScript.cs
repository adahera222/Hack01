using UnityEngine;
using System.Collections;

[System.Serializable]
public class CrossHairStruct {
	public string name;
	public Texture texture;
}

public class CrossHairScript : MonoBehaviour {
	
	//public Texture[] textures;
	public CrossHairStruct[] cursors;
	public int current;
	
	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
		Screen.lockCursor = true;
	}
	
	void Update(){
		//Screen.lockCursor = true;
		Screen.showCursor = false;
		Screen.lockCursor = true;
	}
	
	void OnGUI() {
		if(current == -1) return;
		
		Texture texture = cursors[current].texture;//textures[current];//
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
	
	public void setCursor(string name){
		for(int i = 0; i < cursors.Length; i++){
			//Debug.Log(cursors[i].name);
			if(cursors[i].name == name){
				current = i;
				return;
			}
		}
	}
}

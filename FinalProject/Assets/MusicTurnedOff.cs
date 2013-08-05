using UnityEngine;
using System.Collections;

public class MusicTurnedOff : MonoBehaviour {

	void OnGUI(){
		
		if(GUILayout.Button("Music Off")){
			GetComponent<AudioSource>().enabled=false;
		}
		if(GUILayout.Button("Music On")){
			GetComponent<AudioSource>().enabled=true;
		}
}
}
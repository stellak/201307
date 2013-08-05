using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	
	public Transform target;
    void OnGUI() {
        if (target != transform)
        
	{GUILayout.Label("They are in different place");
		}
        
    }
}

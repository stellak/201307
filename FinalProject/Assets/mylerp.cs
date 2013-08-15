using UnityEngine;
using System.Collections;

public class mylerp : MonoBehaviour {
	public GameObject Stage;
	float thisnumber;
    public float minimum = -5.0F;
    public float maximum = 5.0F;
	
	void Start(){
		
		InvokeRepeating("thisnewthing",5,1f);		
		
	}
	
    void thisnewthing() {
		thisnumber = Random.Range (-5f, 5f);
		if (thisnumber<0) {
        transform.localPosition = new Vector3(0,Mathf.Lerp(minimum, maximum, Time.time), 0);
    }
		if( thisnumber>0) {
		transform.localPosition = new Vector3(0,Mathf.Lerp(minimum,maximum,Time.time),0);
		}
		
			
	}
}

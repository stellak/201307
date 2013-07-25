using UnityEngine;
using System.Collections;

public class IfStatement : MonoBehaviour {
	
	public float coffeeTemperature = 85.0f;
	public float hotLimitTemperature = 60.0f;
	public float coldLimitTemperature = 45.0f;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown (KeyCode.Space))
			TemperatureTest();
		
		coffeeTemperature-= Time.deltaTime *5f;
		
	}
	
	void TemperatureTest()
	{
		if(coffeeTemperature > hotLimitTemperature)
		{
			Debug.Log("coffee is too hot");
		}
		
		else
		{
			Debug.Log ("coffee is just right");
			
		}
		
	}
}

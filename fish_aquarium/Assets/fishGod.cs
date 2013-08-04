using UnityEngine;
using System.Collections;

public class fishGod : MonoBehaviour {

	public fish fishBlueprint;
	
	// Use this for initialization
	void Start () {
		//spawning을 우ㅐ해서는 instantiante를 쓴다. 이걸 위해 위에서 피쉬블루프린트를 선언해주고
		//블루프린트를 프고젝트에 프리팸으로 만들어준다. 
		//프로젝트탭에서 물건을 끌어다가 써라. 신탭에서 끌어ㅓ다 쓰지말고. 
		Instantiate(fishBlueprint)
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			//a for() 
	
	}
}

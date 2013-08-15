using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class mosquitoClick : MonoBehaviour {

// Use this for initialization
void Start () {

        GameLogic.instance.mosquito.Add( this );
}

void Update () {

}


    void OnMouseDown() {
  
        GameLogic.score += 10;
        GameLogic.instance.mosquito.Remove( this );
        Destroy( this.gameObject );
    }
}

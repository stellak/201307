using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameLogic : MonoBehaviour {

    public static GameLogic instance;
    public List<mosquitoClick> mosquito = new List<mosquitoClick>();

    public static int score = 0;

    void Awake() {
       
        mosquito.Clear();

        instance = this;
    }

void Start () {
        
}

void Update () {
      
        if ( Input.GetKeyDown( KeyCode.Escape ) )
            Application.LoadLevel( "newFinal" );

        //
        guiText.text = score.ToString();

        if ( mosquito.Count == 0 ) {
      
            Debug.Log( "You killed them all!" );
        }
}
}

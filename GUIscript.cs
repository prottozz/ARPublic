using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIscript : MonoBehaviour
{
    public string sometext = "testing";
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI(){
        GUI.Box (new Rect(0,0,0,0),"" );
        if (GUI.Button(new Rect(20,20,60,60), "button")){
            Debug.Log("Button is pressed");
        }
        bool buttonPressed = GUI.Button(new Rect(20,80,60,100),"onPress");
        if(buttonPressed){
            Debug.Log("Button2 is pressed");
            sometext = GUI.TextArea(new Rect(20,100,60,140), sometext, 25);
        }

    }
}

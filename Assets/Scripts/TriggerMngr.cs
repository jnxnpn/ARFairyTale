using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;




public class TriggerMngr : MonoBehaviour
{

    public Canvas myCanvas; //Your target for the refference

    void Awake(){
        myCanvas.enabled = false;
    }
    void OnTriggerExit(){
        myCanvas.enabled = false;
    }
    
    //If you want to be more specific to what gets enabled and store it all in one script you can check tags
    
    void OnTriggerEnter(Collider collider){
        print("collision");
        if (collider.gameObject.CompareTag("duck")){
            myCanvas.enabled = true;
        }
    }
    
}

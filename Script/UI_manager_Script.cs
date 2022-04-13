using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_manager_Script : MonoBehaviour
{
    public static UI_manager_Script instance;

    [SerializeField]
    Text pointText; 


    private void Awake() {
        if(instance==null){
            instance=this;
        }
        else{
            Destroy(instance);
        }
    }

    public void updateScore(){
        pointText.text=GM_Script.instance.point.ToString ();
    }
}

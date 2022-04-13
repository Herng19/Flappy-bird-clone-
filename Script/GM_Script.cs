using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_Script : MonoBehaviour
{
    public static GM_Script instance ;

    [SerializeField]
    public float speed;

    [SerializeField]
    public float maxHeightPipe;

    [SerializeField]
    public float minHeightPipe;

    public bool gameOver = false ;
    public int point = 0;


    public void Awake(){
        if(instance==null){
            instance=this;
        }
        else{
            Destroy(this);
        }
    }
}

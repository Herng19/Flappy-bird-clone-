using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseScript : MonoBehaviour
{
    float pointMainCameraLeft;
    float setWidth;


    // Start is called before the first frame update
    void Start()
    {
        pointMainCameraLeft = Camera.main.transform.position.x - Camera.main.orthographicSize * Camera.main.aspect ;

        setWidth = GetComponent<SpriteRenderer>().bounds.size.x / 2f ; 
    }

    // Update is called once per frame
    void Update()
    {
        if(GM_Script.instance.gameOver){
            return;
        }
        else{

         if(transform.position.x <= pointMainCameraLeft - setWidth){

            transform.Translate(Vector3.right * ((setWidth * 5f)- 0.30f));
         }

        transform.Translate(Vector3.left * GM_Script.instance.speed * Time.deltaTime);
        }
    }
}

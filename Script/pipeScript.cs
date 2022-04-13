using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    private float pointCameraLeft;
    private float setWidth;
    private float pointCameraRight;

    // Start is called before the first frame update
    void Start()
    {
        pointCameraLeft = Camera.main.transform.position.x - Camera.main.orthographicSize * Camera.main.aspect ;
        pointCameraRight = Camera.main.transform.position.x + Camera.main.orthographicSize * Camera.main.aspect ;

        setWidth = GetComponentInChildren<SpriteRenderer>().bounds.size.x / 2f ;
        transform.position = ((Vector3.right * transform.position.x) + 
                             (Vector3.up * Random.Range(GM_Script.instance.minHeightPipe, GM_Script.instance.maxHeightPipe)));
    }

    // Update is called once per frame
    void Update()
    {
        if(GM_Script.instance.gameOver){
            return;
        }
        else{
        if(transform.position.x <= pointCameraLeft - setWidth){

        transform.position = ((Vector3.right * (pointCameraRight + (setWidth * 2f))) + 
                             (Vector3.up * Random.Range(GM_Script.instance.minHeightPipe, GM_Script.instance.maxHeightPipe)));


        }

        transform.Translate(Vector3.left * GM_Script.instance.speed * Time.deltaTime);
        }

    }




}

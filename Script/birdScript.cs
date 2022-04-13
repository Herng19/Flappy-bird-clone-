using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class birdScript : MonoBehaviour
{
    Rigidbody2D myRigidBody ;

    [SerializeField]
    private float jumpForce;


    private void Awake(){
        myRigidBody=GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate(){
        if(Input.GetKey(KeyCode.Space)){
            addForce();
        }

    }

    public void addForce(){
        Vector3 Velocity=myRigidBody.velocity;
        Velocity.y = jumpForce;
        myRigidBody.velocity=Velocity; 
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        if(collision.gameObject.CompareTag("base") || collision.gameObject.CompareTag("pipe")){
            GM_Script.instance.speed = 0;
            GM_Script.instance.gameOver = true;
            jumpForce = 0;
            SceneManager.LoadScene("Game Over");
        }

    }

    private void OnTriggerEnter2D(Collider2D trigger) {
        
        if(trigger.CompareTag("point")){
            GM_Script.instance.point++;
        }

        UI_manager_Script.instance.updateScore();
    }
    

}

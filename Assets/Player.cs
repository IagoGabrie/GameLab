using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class Player : MonoBehaviour{
    public float moveSpeed = 5f;
  
    void Start(){}

 
    void Update(){
     Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
     
    Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
    float movimento = Input.GetAxis("Horizontal");
     
    transform.position += movement * Time.deltaTime * moveSpeed;
    if(Input.GetKeyDown(KeyCode.Space)){
     rigidbody.AddForce(new Vector2(0, 300));
    } 
    if(movimento < 0){
     GetComponent<SpriteRenderer>().flipX = true;
    } else if (movimento>0){
    GetComponent<SpriteRenderer>().flipX = false;
    }
    if(movimento > 0 || movimento < 0){
    GetComponent<Animator>().SetBool("andando", true);
    } else{
    GetComponent<Animator>().SetBool("andando", false);
    }   
  
}
}

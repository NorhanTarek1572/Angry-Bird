using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{

    Rigidbody2D rb ;
    SpriteRenderer  sprite ;
    public float speed;
    public float maxDrag;
    Vector2 currentPosition;
    Vector2 startPosition;
    Vector2 direction;

 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        sprite = rb.GetComponent<SpriteRenderer>();

        rb.isKinematic= true;
        startPosition = rb.position;

    }

    void Update(){
        
    }
   private void OnMouseDown()
    {
        sprite.color = Color.red;
    }

    private void OnMouseUp()
    {
       // how to make it move from position 1 to posithion 2  
       BirdMovement();
        // change the color again to the real color 
        sprite.color = Color.white;   
        LivesCounter.health -- ;
       
    }

    private void OnMouseDrag()
    {   
        // to make limit in movement 
        FlyingLimits();     
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // when the pleyer touch any thing has collision it should be restart with a delay
        StartCoroutine( ResetDelay() );
        
    }

    IEnumerator ResetDelay() {
         // when the pleyer touch any thing has collision it should be restart with a delay
        yield return new WaitForSeconds(2);
        rb.position = startPosition;
        rb.isKinematic = true;
        rb.velocity = Vector2.zero;
        

    }
    

    void BirdMovement(){
        // how to make it move from position 1 to posithion 2  
        currentPosition = rb.position;
        direction = startPosition - currentPosition;
        direction.Normalize();
        rb.isKinematic = false;
        
        rb.AddForce(direction * speed);
    }
    
    void FlyingLimits(){
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // to take our position from our main camera 
        
        // to make limit in movement 
        Vector2 desiredPosition = mousePosition;   // it is the same Vector3(mousePosition.x, mousePosition.y, transform.position.z)
        float distance = Vector2.Distance(desiredPosition, startPosition); // to make the drag only on one way not in all screan 
        
        if(distance > maxDrag)
        {
            direction =desiredPosition - startPosition;
            direction.Normalize();
            desiredPosition = startPosition + (direction * maxDrag) ;
        }
        
        if (desiredPosition.x > startPosition.x)
        {
            desiredPosition.x = startPosition.x; // to make it move in right only                                              
        }
        rb.position = desiredPosition;

    }


/*
    void FlyingLimits(){
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // to take our position from our main camera       
        Vector2 desiredPosition = mousePosition; // to make limit in movement 
        float distance = Vector2.Distance(desiredPosition, startPosition); // to make the drag only on one way not in all screan 
        MaxDrag();
        FlayingDirection();
      
       
    }
    void MaxDrag(){
        if(distance > maxDrag)
        {
            direction =desiredPosition - startPosition;
            direction.Normalize();
            desiredPosition = startPosition + (direction * maxDrag) ;
        }
        
    }
    void FlayingDirection(){
        if (desiredPosition.x > startPosition.x)
        {
            desiredPosition.x = startPosition.x; // to make it move in right only                                              
        }
         rb.position = desiredPosition;
    }

*/


}

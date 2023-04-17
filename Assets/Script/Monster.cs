using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D collision)
    {
        // when the bird touch the enemys , the enemys should disapper 
        if (collision.gameObject.tag == "Bird" ) {          
            gameObject.SetActive(false);
        }
    
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigos : MonoBehaviour
{
    


    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "tiro")
      {
       
        Destroy(gameObject);

      }
    }


}
 



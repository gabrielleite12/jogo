using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoP : MonoBehaviour
{
  public Transform chidori;
  public GameObject chiOb;
  public float chirate;
  private float nextchi;


  public float Speed;
  public float Jumpforce;


  public bool pulo;
  public bool doupulo;


  private Rigidbody2D rig;
  private Animator anime;



 

  // shuriquen
  public Transform tiroS;
  public GameObject tiroOb;
  public float firerate;
  private float nextfire;

 


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        Jump();

      

        if(Input.GetButton("Fire1") && Time.time > nextfire){
          nextfire = Time.time + firerate;
            GameObject tempBullet = Instantiate (tiroOb, tiroS.position, tiroS.rotation);
        }


        if(Input.GetButton("Fire2") && Time.time > nextchi){
          nextchi = Time.time + chirate;
            GameObject tempBullet = Instantiate (chiOb, chidori.position, chidori.rotation);
        }




 

      
    }


    void move()
    {
    	Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
    	transform.position += movement * Time.deltaTime * Speed;

      if(Input.GetAxis("Horizontal")> 0f)
      {
        anime.SetBool("run", true);
        transform.eulerAngles = new Vector3(0f,0f,0f);
      }

       if(Input.GetAxis("Horizontal")< 0f)
      {
        anime.SetBool("run", true);
        transform.eulerAngles = new Vector3(0f,180f,0f);
      }

       if(Input.GetAxis("Horizontal") == 0f)
      {
        anime.SetBool("run", false);
      }

    }


    void Jump()
    {
      if(Input.GetButtonDown("Jump"))
      {
         if(pulo)
         {
             rig.AddForce(new Vector2(0f, Jumpforce), ForceMode2D.Impulse);
             doupulo = true;
             anime.SetBool("jump", true);

         }
         else
         {

          if(doupulo)
          {

            rig.AddForce(new Vector2(0f, Jumpforce * 2), ForceMode2D.Impulse);
            doupulo = false;
            

          }


         }
      }

    }

   


  


    void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.layer == 8)
      {
        pulo = true;

      }


    }
   
    void OnCollisionExit2D(Collision2D collision)
    {
      if(collision.gameObject.layer == 8)
      {
        pulo = false;
        anime.SetBool("jump", false);
      }

       if(collision.gameObject.tag == "espinhos")
      {
        pontos.instance.gameover();
        Destroy(gameObject);

      }


  
    


    }


    
   
}

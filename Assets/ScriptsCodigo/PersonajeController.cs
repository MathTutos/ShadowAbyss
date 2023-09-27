using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeController : MonoBehaviour
{
    
     
     float Niveltecho = -2f;
     float velocidad = 5f;
     float fuerzaImpulso = 10000;
     float fuerzasalto = 37;
     bool Piso = true;
     bool hasJump = false;

     private Rigidbody2D rb2d;
     private Animator animator;
     private SpriteRenderer spriteR;
     private CharacterStatsManager manager;
     
     [SerializeField] private AudioSource Salto_SFX;
    // Start is called before the first frame update //
    void Start()
    {

        manager = GetComponent<CharacterStatsManager>();
        transform.position = manager.getRespawnPoint();
        Debug.Log("[PersonajeController] - Start");
        //gameObject.transform.position = new Vector3(-7.56f, Niveltecho,0);
        Debug.Log("INT");
        Debug.Log("VIDAS");
        rb2d = GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        spriteR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.rotation.z > 0.3 || gameObject.transform.rotation.z < -0.3){
            Debug.Log("ROTATION: " + gameObject.transform.rotation.z);
            gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }


        if(Input.GetKey("right")){
              gameObject.transform.Translate(velocidad*Time.deltaTime, 0, 0);
              animator.SetBool("Running", true);
              spriteR.flipX=false;
        }
        else if (Input.GetKey("left")){
              gameObject.transform.Translate(-velocidad*Time.deltaTime, 0, 0);
              animator.SetBool("Running", true);
              spriteR.flipX=true;
        } 

        if( !(Input.GetKey("right") || Input.GetKey("left")) ){
            animator.SetBool("Running", false);

        }

        // ** Detector de movimiento descendente **
        //    Sirve para cambiar la animación del personaje y como
        //    límite para realizar un segundo salto
        if(rb2d.velocity.y < -0.1){
            hasJump = false;
            animator.SetBool("Falling", true);
            animator.SetBool("Jump", false);
            animator.SetBool("DoubleJump", false);
        }

        if((Input.GetKeyDown("space") && Piso)||(Input.GetKeyDown("space") && hasJump)){
            Debug.Log("UP - Piso: " + Piso);
            if(hasJump){
                // Esto se ejecuta cuando YA HA SALTADO por primera vez
                animator.SetBool("DoubleJump", true);
                hasJump  = false;
                float d_i = 1;
                if(rb2d.velocity.x < 0) d_i = -1; // ¿El personaje va para la derecha o la izquierda?
                //fuerza vertical y horizontal - como el personaje está en el aire es necesario imprimirle también fuerza horizontal
                rb2d.AddForce(new Vector2(d_i*fuerzaImpulso, -0.5f*fuerzasalto*Physics2D.gravity[1]*rb2d.mass));
            }
            else{
                // Esto se ejecuta cuando es el PRIMER SALTO
                Salto_SFX.Play();
                hasJump  = true;
                animator.SetBool("Jump", true);
                animator.SetBool("DoubleJump", false);

                rb2d.AddForce(new Vector2(0, -fuerzasalto*Physics2D.gravity[1]*rb2d.mass));
            }
            Piso = false;
        }

      

        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.tag == "Ground"){
            Piso = true;
            Debug.Log("GROUND COLLISION");
            animator.SetBool("Falling", false);
            
        }
        else if(collision.transform.tag == "Obstaculo"){
            Piso = true;
            Debug.Log("OBSTACLE COLLISION");
            
        }
    }

        
    
}

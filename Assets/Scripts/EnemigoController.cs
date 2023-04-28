using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemigoController : MonoBehaviour
{
    public GameObject gameManager;
    private int vidas = 2;
    public float xVelocity = 1f;    
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        var yVelocity = rb.velocity.y;
        
        rb.velocity = new Vector2(-xVelocity, yVelocity);
    }


    public void  VidaEnemigo(){
        vidas = vidas - 1;
        if(vidas == 0){  
            ZombiesMuertos();
            //Debug.Log(ZombiesMuertos);
            Destroy(gameObject);  
                       
        }
    }


    private void ZombiesMuertos() {
      var gm = gameManager.GetComponent<GameManager>();
      var uim = gameManager.GetComponent<UiManager>();

      gm.ZombiesMuertos();
      uim.PrintZombiesMuertos(gm.GetZombiesMuertos());
    }
}

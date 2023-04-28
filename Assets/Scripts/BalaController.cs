using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{

    //public GameObject gameManager;
    public float velocityX = 0.1f;
    public float velocityY = 0f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocityX, velocityY);
    }

    public void DestroyBullet(){
        Destroy(gameObject);
    }
    
    void OnTriggerEnter2D(Collider2D collision) {
        PlayerController player = collision.GetComponent<PlayerController>();
        EnemigoController enemigo = collision.GetComponent<EnemigoController>();
        if(player != null){
            player.Vida();
        }
        if(enemigo != null){
            enemigo.VidaEnemigo();
        }
        DestroyBullet();
    }

   
}

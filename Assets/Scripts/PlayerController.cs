using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public AudioClip[] audios;
    public GameObject gameManager;
    public GameObject bala;
    //public GameObject moneda;
    //public GameObject Enemigo;

    private int vidas = 1;
    //private int cantidadBalas = 5;
    private GameObject balaGenerada;
    private bool balaExiste = false;
    private Rigidbody2D rb;
    private AudioSource audioSource;
    private Transform balaTransform;
    

    
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
      Saltar();
      Disparar();
      DividirDisparo();
      
    }
    private void Saltar() {
      if(Input.GetKeyUp(KeyCode.Space)) {
        audioSource.PlayOneShot(audios[0]);
      }
    }

    private void Disparar() {
      if(Input.GetKeyUp(KeyCode.X)) {
        balaExiste = true;
        var position = transform.position;
        var x = position.x + 1;
        var newPosition = new Vector3(x, position.y, position.z);
        
        balaGenerada = Instantiate(bala, newPosition, Quaternion.identity);
        balaTransform = balaGenerada.transform;
        GanarPuntos();
      }
    }

   
    private void DividirDisparo() {
      // solo se divide si la bala existe y presiono C
      //transform.position
      if(balaExiste && Input.GetKeyUp(KeyCode.D)) {

        var position = balaTransform.position;
        var positionBala2 = new Vector3(position.x + 1, position.y + 1, position.z); 
        var positionBala3 = new Vector3(position.x + 1, position.y - 1, position.z); 

        GameObject balaGenerada2 = Instantiate(bala, positionBala2, Quaternion.identity);

        (balaGenerada2.GetComponent<BalaController>()).velocityY = 1;

        GameObject balaGenerada3 = Instantiate(bala, positionBala3, Quaternion.identity);

        (balaGenerada3.GetComponent<BalaController>()).velocityY = -1;
      }
    }

    /*private void MonedasP(){
      var position = transform.position;
      GameObject balaGenerada = Instantiate(moneda, position, Quaternion.identity);
      GanarMonedas();
    }*/

    private void GanarPuntos() {
      var gm = gameManager.GetComponent<GameManager>();
      var uim = gameManager.GetComponent<UiManager>();

      gm.GanarPuntos();
      uim.PrintPuntaje(gm.GetPuntaje());
    }



  
   /* private void GanarMonedas() {
      var gm = gameManager.GetComponent<GameManager>();
      var uim = gameManager.GetComponent<UiManager>();
      audioSource.PlayOneShot(audios[1]);
      gm.GetMonedas();
      uim.PrintMonedas(gm.GetMonedas());
             
    }

    void OnTriggerEnter2D(Collider2D other) {
      var gm = gameManager.GetComponent<GameManager>();
      var uim = gameManager.GetComponent<UiManager>();
        if(other.gameObject.tag == "moneda"){
             audioSource.PlayOneShot(audios[1]);
             gm.GetMonedas();
             uim.PrintMonedas(gm.GetMonedas());
             Destroy(other.gameObject);         
         }
        //Debug.Log("trigger");
        //Debug.Log(other.gameObject.name);
        //Destroy(this.gameObject);
        
    }*/

public void  Vida(){
  vidas = vidas - 1;
  if(vidas == 0)Destroy(gameObject);
}

   /*  private void OnCollisionEnter2D(Collision2D other) {
        var gm = gameManager.GetComponent<GameManager>();
      var uim = gameManager.GetComponent<UiManager>();
        if(other.gameObject.tag == "Enemigo"){
           audioSource.PlayOneShot(audios[1]);
             gm.PerderVidas();

               vidas++;
            if(vidas == 3)
            {
                audioSource.PlayOneShot(audios[1]);
                Time.timeScale = 0;
                
            }
         }
     }*/

}

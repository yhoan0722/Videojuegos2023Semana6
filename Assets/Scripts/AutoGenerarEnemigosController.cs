using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGenerarEnemigosController : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public Transform puntoAparicion;
    public float tiempoAparicion = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarEnemigo", tiempoAparicion, tiempoAparicion);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerarEnemigo()
    {
        Instantiate(enemigoPrefab, puntoAparicion.position, Quaternion.identity);
    }

    
}

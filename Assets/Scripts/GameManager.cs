using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int Puntaje = 0;
    private int Vidas = 3;
    private int moneda = 0;
    private int Zombies = 0;
    // Start is called before the first frame update
    
    public void GanarPuntos() {
        Puntaje +=1;
    }
    public void GanarMonedas() {
        moneda +=1;
    }
     public void ZombiesMuertos() {
        Zombies +=1;
    }

    public void PerderVidas() {
        if(Vidas > 0)
            Vidas -= 1;
    }

    public int GetPuntaje() {
        return Puntaje;
    }

     public int GetMonedas() {
        return moneda;
    }
    public int GetZombiesMuertos() {
        return Zombies;
    }
    public int GetPerderVidas() {
        return Vidas;
    }
}

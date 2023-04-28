using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Text PuntajeText;
    public Text Monedas;
    public Text Vidas;
    public Text ZombiesText;


    public void PrintPuntaje(int puntos) {
        PuntajeText.text = "Puntaje: " + puntos;
    }

    public void PrintMonedas(int monedas) {
        Monedas.text = "Monedas: " + monedas;
    }

    public void PrintVidas(int vidas) {
        Monedas.text = "Vidas: " + vidas;
    }

    public void PrintZombiesMuertos(int zombies) {
        ZombiesText.text = "Zombies: " + zombies;
    }
}

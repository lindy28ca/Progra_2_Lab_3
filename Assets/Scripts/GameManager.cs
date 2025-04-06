using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase Singleton para controlar el juego y la puntuación
public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Instancia única del GameManager
    public int score;                   // Puntuación del jugador

    private void Awake()
    {
        // Si no existe una instancia, la asigna. Si ya hay una, destruye el duplicado.
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    // Suma puntos al score
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Puntuación actual: " + score);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase que representa a un enemigo
public class Enemigo : MonoBehaviour
{
    private string enemyName;

    // Constructor con nombre
    public Enemigo(string _name)
    {
        enemyName = _name;
        Debug.Log("Se creó el enemigo: " + enemyName);
    }

    private void Update()
    {
        // Si se presiona la tecla D, destruye al enemigo
        if (Input.GetKeyDown(KeyCode.D))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        // Suma 10 puntos al destruir un enemigo
        GameManager.Instance.AddScore(10);
        Debug.Log("Enemigo destruido: " + enemyName);
    }
}
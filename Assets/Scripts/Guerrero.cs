using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
using UnityEngine;

// Clase Guerrero que hereda de Personaje
public class Guerrero : Personaje
{
    #region Private
    private int Ira; // Nivel de ira del guerrero
    #endregion

    #region Getters
    public int ira => Ira; // Propiedad pública para acceder a la ira
    #endregion

    #region Constructors
    // Constructor con parámetros
    public Guerrero(string _charName, string _description, int _Ira) : base(_charName, _description)
    {
        Ira = _Ira; // Asigna el valor de ira recibido
    }

    // Implementación del método abstracto de Personaje
    protected override void Estadísticas()
    {
        Debug.Log("Nombre: " + CharName);       // Muestra el nombre del personaje
        Debug.Log("Descripción: " + Description); // Muestra su descripción
        Debug.Log("Ira: " + ira);               // Muestra su valor de ira
    }
    #endregion
}
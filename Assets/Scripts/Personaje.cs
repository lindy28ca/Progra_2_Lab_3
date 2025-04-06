using UnityEngine;

// Clase abstracta base para todos los personajes
abstract public class Personaje : MonoBehaviour
{
    #region Private
    protected string charName;      // Nombre del personaje
    protected string description;   // Descripción del personaje
    #endregion

    #region Getters
    public string CharName => charName;         // Propiedad de solo lectura para acceder al nombre
    public string Description => description;   // Propiedad de solo lectura para acceder a la descripción
    #endregion

    #region Constructors
    // Constructor por defecto (no se puede usar directamente en Unity para MonoBehaviour, pero se deja por estructura)
    protected Personaje()
    {
        charName = "null";
        description = "null";
    }

    // Constructor con parámetros, ahora corregido
    protected Personaje(string _charName, string _description)
    {
        charName = _charName;        // Asigna el nombre
        description = _description; // Asigna la descripción
    }
    #endregion

    #region Methods
    // Método abstracto que deben implementar las clases hijas para mostrar estadísticas
    protected abstract void Estadísticas();

    // Método que se llama en cada frame por Unity
    protected void Update()
    {
        // Si el jugador presiona la tecla ESPACIO, se muestran las estadísticas del personaje
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Estadísticas();
        }

        // El personaje se destruye automáticamente después de 2 segundos
        Destroy(this.gameObject, 2f);
    }

    // Se ejecuta cuando el objeto es destruido
    protected void OnDestroy()
    {
        print("Me han destruido zhasbot!"); // Mensaje de despedida
    }
    #endregion
}
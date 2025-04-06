using UnityEngine;

// Clase abstracta base para todos los personajes
abstract public class Personaje : MonoBehaviour
{
    #region Private
    protected string charName;      // Nombre del personaje
    protected string description;   // Descripci�n del personaje
    #endregion

    #region Getters
    public string CharName => charName;         // Propiedad de solo lectura para acceder al nombre
    public string Description => description;   // Propiedad de solo lectura para acceder a la descripci�n
    #endregion

    #region Constructors
    // Constructor por defecto (no se puede usar directamente en Unity para MonoBehaviour, pero se deja por estructura)
    protected Personaje()
    {
        charName = "null";
        description = "null";
    }

    // Constructor con par�metros, ahora corregido
    protected Personaje(string _charName, string _description)
    {
        charName = _charName;        // Asigna el nombre
        description = _description; // Asigna la descripci�n
    }
    #endregion

    #region Methods
    // M�todo abstracto que deben implementar las clases hijas para mostrar estad�sticas
    protected abstract void Estad�sticas();

    // M�todo que se llama en cada frame por Unity
    protected void Update()
    {
        // Si el jugador presiona la tecla ESPACIO, se muestran las estad�sticas del personaje
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Estad�sticas();
        }

        // El personaje se destruye autom�ticamente despu�s de 2 segundos
        Destroy(this.gameObject, 2f);
    }

    // Se ejecuta cuando el objeto es destruido
    protected void OnDestroy()
    {
        print("Me han destruido zhasbot!"); // Mensaje de despedida
    }
    #endregion
}
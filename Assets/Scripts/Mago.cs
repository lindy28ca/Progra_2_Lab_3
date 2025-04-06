using UnityEngine;

public class Mago : Personaje
{
    public int wisdom;  // Sabiduría del mago
    public int mana;    // Maná del mago

    // Constructor que inicializa todos los campos
    public Mago(string _charName, string _description, int _wisdom, int _mana) : base(_charName, _description)
    {
        wisdom = _wisdom;
        mana = _mana;
        Debug.Log("Se creo un Mago");
    }

    // Constructor por copia
    public Mago(Mago copy) : base(copy.name, copy.Description)
    {
        wisdom = copy.wisdom;
        mana = copy.mana;
        Debug.Log("Se creo un Mago");
    }

    // Implementación del método Estadísticas
    protected override void Estadísticas()
    {
        Debug.Log("Nombre: " + CharName);
        Debug.Log("Descripción: " + Description);
        Debug.Log("Mana: " + mana);
    }
}

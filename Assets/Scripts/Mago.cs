using UnityEngine;

public class Mago : Personaje
{
    public int wisdom;  // Sabidur�a del mago
    public int mana;    // Man� del mago

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

    // Implementaci�n del m�todo Estad�sticas
    protected override void Estad�sticas()
    {
        Debug.Log("Nombre: " + CharName);
        Debug.Log("Descripci�n: " + Description);
        Debug.Log("Mana: " + mana);
    }
}

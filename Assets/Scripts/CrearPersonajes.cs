using UnityEngine;

// Clase para crear personajes presionando teclas
public class CrearPersonajes : MonoBehaviour
{
    private void Update()
    {
        // Si se presiona G, crea un Guerrero
        if (Input.GetKeyDown(KeyCode.G))
        {
            GameObject go = new GameObject();
            Guerrero guerrero = go.AddComponent<Guerrero>(); // se le agrega el componente (clase Guerrero)
            guerrero = new Guerrero("Lord", "Se enoja mucho", Random.Range(100, 500)); // se inicializa
        }
        // Si se presiona M, crea un Mago
        else if (Input.GetKeyDown(KeyCode.M))
        {
            GameObject go = new GameObject();
            Mago mago = go.AddComponent<Mago>();
            mago = new Mago("El hechicero", "Con sus poderes", Random.Range(0, 10), Random.Range(0, 10));
        }
        // Si se presiona E, crea un Enemigo
        else if (Input.GetKeyDown(KeyCode.E))
        {
            GameObject go = new GameObject();
            Enemigo enemigo = go.AddComponent<Enemigo>();
            enemigo = new Enemigo("Enemigo");
        }
    }
}

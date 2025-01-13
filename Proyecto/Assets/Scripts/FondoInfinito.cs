using UnityEngine;

public class FondoInfinitoDerecha : MonoBehaviour
{
    public float velocidad = 3f; // Velocidad de desplazamiento del fondo.
    private float anchoFondo;   // Ancho del sprite del fondo.

    void Start()
    {
        // Obtener el ancho del sprite del fondo.
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            anchoFondo = sr.bounds.size.x;
        }
    }

    void Update()
    {
        // Mover el fondo hacia la derecha.
        transform.position += Vector3.right * velocidad * Time.deltaTime;

        // Verificar si el fondo salió completamente de la pantalla por la derecha.
        if (transform.position.x >= anchoFondo)
        {
            // Reposicionar el fondo al frente del otro lado.
            transform.position -= new Vector3(anchoFondo * 2, 0, 0);
        }
    }
}

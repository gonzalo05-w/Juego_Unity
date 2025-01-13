using UnityEngine;
using UnityEngine.SceneManagement;
public class ColliderDisappear : MonoBehaviour
{
    // Define el tag del objeto con el que el personaje debe colisionar
    [SerializeField] private string targetTag = "PostLlamas";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Comprueba si el objeto con el que colisionó tiene el tag especificado
        if (collision.gameObject.CompareTag(targetTag))
        {
            // Desactiva el GameObject del personaje (lo "desaparece")
            gameObject.SetActive(false);
            SceneManager.LoadScene("PostLLamas");
        }
    }
}


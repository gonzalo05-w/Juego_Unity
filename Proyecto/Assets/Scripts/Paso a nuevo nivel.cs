
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pasoanuevonivel : MonoBehaviour
{
    [SerializeField] private string targetTag = "Paso nivel 2";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
       private void OnCollisionEnter2D(Collision2D collision){
        // Comprueba si el objeto con el que colisionó tiene el tag especificado
        if (collision.gameObject.CompareTag(targetTag))
        {
            // Desactiva el GameObject del personaje (lo "desaparece")
            gameObject.SetActive(false);
            SceneManager.LoadScene("Paso nivel 2");
            
            
        }

    } 
    public void LoadGame(){

        //Cargar la escena del juego
        SceneManager.LoadScene("Paso nivel 2");
    }

}

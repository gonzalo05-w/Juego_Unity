using UnityEngine;
using UnityEngine.SceneManagement;
public class Pasoanivel2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadGame(){

        //Cargar la escena del juego
        SceneManager.LoadScene("Juego 2ºParte");
    }
}

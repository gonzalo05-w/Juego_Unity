using UnityEngine;

public class ControlEnemigo : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D collider){
        gameObject.SetActive(false);
    }
}

// using UnityEngine;

// public class ControlEnemigo : MonoBehaviour
// {
//     private void OnTriggerEnter2D (Collider2D collider){
//         gameObject.SetActive(false);
//     }
// }

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ControlEnemigo : MonoBehaviour
{
    // private bool estaTirado = false;

    // private void OnTriggerEnter2D(Collider2D collider)
    // {
    //     if (!estaTirado)
    //     {
    //         // Girar el enemigo 90 grados.
    //         transform.rotation = Quaternion.Euler(0, 0, 90);

    //         // Ajustar la posición para simular que está en el suelo.
    //         transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);

    //         // Desactivar cualquier movimiento o comportamiento adicional aquí si lo necesitas.
    //         estaTirado = true;
    //     }
    // }

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
            GameManager.Instance.PerderVida();
        }
    }
}

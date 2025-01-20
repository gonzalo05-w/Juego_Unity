

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Enemigo : MonoBehaviour
{
    

    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Player")){
            GameManager.Instance.PerderVida();
        }
    }
}

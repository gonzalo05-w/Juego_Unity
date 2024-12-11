using UnityEngine;

public class CameraControl : MonoBehaviour
{
public Transform target; // Transform del personaje a seguir
    public Vector3 offset; // Desplazamiento opcional entre la cámara y el personaje
    public float smoothSpeed = 0.125f; // Velocidad de suavizado del movimiento

    void LateUpdate()
    {
        if (target != null)
        {
            // Calcula la posición deseada
            Vector3 desiredPosition = target.position + offset;

            // Suaviza el movimiento hacia la posición deseada
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Establece la posición suavizada sin modificar la rotación
            transform.position = smoothedPosition;

            // Mantiene la rotación fija
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}


 
using System.Collections; 
using UnityEngine;

public class Movimientos : MonoBehaviour
{
    private bool isGrounded; // Verifica si está en el suelo
    private BoxCollider2D boxCollider;
    private SpriteRenderer spriteRenderer;
    private Animator animator; // Referencia al Animator
    private bool isAttacking;
    // Start se llama una vez antes de ejecutar por primera vez el Update
    void Start()
    {
        // Obtener componentes
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        // Obtén el componente Animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Actualizar tamaño y posición del colisionador según el sprite
        boxCollider.size = spriteRenderer.sprite.bounds.size;
        boxCollider.offset = spriteRenderer.sprite.bounds.center;

        // Mover a la izquierda con la tecla left
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-700f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        // Mover a la derecha con la tecla right
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(700f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        // Si no se presionan teclas de movimiento
        if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }

        // Saltar al presionar up si está en el suelo
        if (Input.GetKeyDown("up") && isGrounded)
        {
            gameObject.GetComponent<Animator>().SetBool("jump", true);
            isGrounded = false; // Evitar múltiples saltos en el aire
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 600f));
        }

        if (Input.GetKeyDown("down") && isAttacking)
        {
            gameObject.GetComponent<Animator>().SetBool("attack", true);
            isAttacking = true; 
            
        }
    }

    // Detectar colisión con el suelo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo")) 
        {
            isGrounded = true;
            gameObject.GetComponent<Animator>().SetBool("jump", false); // Desactivar animación de salto
            
        }
    }
}

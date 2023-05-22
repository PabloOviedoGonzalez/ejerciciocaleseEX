using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum PlayerState { Idle, Walk, Jump };
    [HideInInspector]
    public PlayerState pState;

    public float speed, jumpHeight, maxHealth, maxStamina;
    public LayerMask groundLayer;
    public PlayerStats stats; // lo dejamos en public para debug

    private Rigidbody2D rb;
    private SpriteRenderer rend;
    private float lastX;
    private bool canMove = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();

        // (EJ) controlar la excepcion que puede darse aqui con el respectivo try-catch. Si se pasa de 100 alguna de las dos (es decir, se ha lanzado excepcion),
        // hay que resetear las variables a 100, avisar al usuario y volver a instanciar stats
        try
        {
            stats = new PlayerStats(maxHealth, maxStamina);
        }
        catch (Exception e)
        {
            Debug.Log("Valor de stamina o vida no acceptado");
            maxStamina = maxHealth = 100;
            stats = new PlayerStats(maxHealth, maxStamina);
        }
       
        
    }

    // Update is called once per frame
    void Update()
    {

        // si la stamina es mayor a 0, se puede mover
        if (stats.GetStamina() > 0 && canMove)
            Movement();

        Jump();
        Shoot();
        Rest();
    }

    void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal");
        if(x != 0)
        {
            lastX = x;
            pState = PlayerState.Walk;
        }
        else
        {
            pState = PlayerState.Idle;
        }

        rb.velocity = new Vector2(speed * stats.GetStamina() / maxStamina * x, rb.velocity.y);

        rend.flipX = lastX < 0;

        // bajamos la stamina si está corriendo
        stats.AddToStamina(-Mathf.Abs(x * Time.deltaTime * 20));
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
            pState = PlayerState.Jump;
        }
    }

    bool IsGrounded()
    {
        RaycastHit2D raycast =
            Physics2D.Raycast(transform.position, Vector2.down, 0.8f, groundLayer);

        return raycast;
    }

    void Rest()
    {
        if(stats.GetStamina() < 100)
            stats.AddToStamina(Time.deltaTime * 10);
    }

    // (EJ) rellena el metodo para que, cuando el usuario pulse el boton izquierdo del raton,
    // acceda a una bala de los stats, la active, le agregue el componente 'Bullet',
    // ponga su posicion en la del jugador y establezca su direccion (utiliza la variable lastX).
    // Recuerda controlar las excepciones con los correspondientes 'try-catch'
    void Shoot()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private PlayerController pm;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        pm = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();


        // (EJ) Lanza una excepcion del tipo 'ForgotToAddComponentException' si pm es null y destruye
        // este componente para evitar errores
        if (!pm)
        {
            throw new ForgotToAddComponentException();
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (pm.pState)
        {
            case PlayerController.PlayerState.Idle:
                animator.SetBool("isWalking", false);
                break;
            case PlayerController.PlayerState.Walk:
                animator.SetBool("isWalking", true);
                break;
            case PlayerController.PlayerState.Jump:
                break;
        }
    }
}

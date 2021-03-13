using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;


public class playerInteraction : MonoBehaviour
{
    [SerializeField] private LayerMask playerLayers;
    [SerializeField] private UnityEvent interacted;

    private Collider2D myCollider;


    private void Start()
    {
        myCollider = GetComponent<Collider2D>();
    }

    public void Interact(InputAction.CallbackContext context)
    {
        if (context.ReadValue<float>() >= 0.5f)
        {
            if (myCollider.IsTouchingLayers(playerLayers))
            {
                interacted.Invoke();
            }
        }
    }
}

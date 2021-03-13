using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;  

public class shooting : MonoBehaviour
{
    [SerializeField] private GameObject projectile;

    public void Shoot(InputAction.CallbackContext context)
    {
        var bullet = Instantiate(projectile, transform.position, Quaternion.identity);

       //   Physics.IgnoreCollision(gameObject.GetComponentInParent<Collider>(), bullet.GetComponent<Collider>());
    }
 
}

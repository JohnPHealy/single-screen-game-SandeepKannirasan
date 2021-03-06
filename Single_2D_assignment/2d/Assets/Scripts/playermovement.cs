using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    [SerializeField] private float moveForce, maxSpeed ,jumpForce;
    [SerializeField] private Collider2D groundCheck;
    [SerializeField] private LayerMask groundLayers;

    //health
    public int health = 4;
    public Text healthDisplay;



    private Rigidbody2D myRB;
    private float moveDir;
    private bool canJump;

    public int extraJump;


    //health
    private void Update()
    {
        healthDisplay.text = health.ToString();

        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }



    private void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
       
    }

    private void FixedUpdate()


    {
        var moveAxis = Vector3.right * moveDir;

        if (Mathf.Abs(myRB.velocity.x)< maxSpeed)
        {

        myRB.AddForce(moveAxis * moveForce, ForceMode2D.Force);

        }

        if(groundCheck.IsTouchingLayers(groundLayers))
        {
            canJump = true;
        }

        else
        {
            canJump = false;    
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveDir = context.ReadValue<float>();
    }

    public void Jump(InputAction.CallbackContext context)
        

   {
   if (canJump && context.started)
        { 
            myRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
        canJump = false;


        if (context.canceled && myRB.velocity.y > 0)
        {
            myRB.velocity = new Vector2(myRB.velocity.x, y: 0f);
        }
    }




   
}

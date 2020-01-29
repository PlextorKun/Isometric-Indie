using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region movement_variables
    public float movespeed;
    float x_input;
    float y_input;
    #endregion

    #region physics_components
    Rigidbody2D playerRB;
    #endregion

    #region Unity_functions
    private void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        x_input = Input.GetAxisRaw("Horizontal");
        y_input = Input.GetAxisRaw("Vertical");

        Move();
    }
    #endregion

    #region movement_functions

    private void Move()
    {
        if (x_input > 0)
        {
            playerRB.velocity = Vector2.right * movespeed;
        } 
        else if (x_input < 0)
        {
            playerRB.velocity = Vector2.left * movespeed;
        }
        else if (y_input > 0)
        {
            playerRB.velocity = Vector2.up * movespeed;
        }
        else if (y_input < 0)
        {
            playerRB.velocity = Vector2.down * movespeed;
        }
        else
        {
            playerRB.velocity = Vector2.zero;
        }

    }
    #endregion
}

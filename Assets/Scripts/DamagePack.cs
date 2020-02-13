using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePack : MonoBehaviour
{
    #region healthPack_variables
    [SerializeField]
    [Tooltip("Assign the healing value of the health pack!")]
    private int damageAmount;
    #endregion

    #region functions
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            if (PlayerController.currHealth == 1)
            {
                Destroy(this.gameObject);
            }
            else
            {
                collision.transform.GetComponent<PlayerController>().Heal(damageAmount);
                Destroy(this.gameObject);
            }            
        }
    }
    #endregion
}

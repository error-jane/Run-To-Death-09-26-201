using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoWin : MonoBehaviour
{
    public bool Verson2 = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Verson2 == false)
        {
            if (collision.CompareTag("Player"))
            {
                collision.GetComponent<PlayerGoControll>().win = true;
                Debug.Log(collision.GetComponent<PlayerGoControll>().win);
            }
        }
        else
        {
            if (collision.CompareTag("Player"))
            {
                collision.GetComponent<PlayerWControll>().win = true;
                Debug.Log(collision.GetComponent<PlayerWControll>().win);
            }
        }
    }
}

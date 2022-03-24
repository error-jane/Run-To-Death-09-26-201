using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepM : MonoBehaviour
{
    public int eyeScore = 1;
    public GameObject effectSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Instantiate(effectSound, transform.position, Quaternion.identity);
            collision.GetComponent<PlayerWControll>().score += eyeScore;
            Debug.Log(collision.GetComponent<PlayerWControll>().score);
            Destroy(gameObject);
        }
        if (collision.CompareTag("DeleteOBJ"))
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtacleW : MonoBehaviour
{
    public int damage = 1;
    public GameObject effect;
    public Animator camAnim;

    public GameObject effectSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(effectSound, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            camAnim.SetTrigger("shake");
            collision.GetComponent<PlayerWControll>().health -= damage;
            Debug.Log(collision.GetComponent<PlayerWControll>().health);
            Destroy(gameObject);
        }

        if (collision.CompareTag("DeleteOBJ"))
        {
            Destroy(gameObject);
        }



    }
}

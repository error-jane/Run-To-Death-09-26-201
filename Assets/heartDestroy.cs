using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartDestroy : MonoBehaviour
{
    public GameObject effect;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeleteHeart"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }


}

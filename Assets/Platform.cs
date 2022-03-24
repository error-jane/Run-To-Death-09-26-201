using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;

    public float endX;
    public float startX;

    private void Update()
    {
        
        if (transform.position.x > endX)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
      
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepratingBG : MonoBehaviour
{
    public float speed;
    public bool typeRe = false;

    public float endX;
    public float startX;
  
    private void Update()
    {
        if (typeRe == false)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (transform.position.x <= endX)
            {
                Vector2 pos = new Vector2(startX, transform.position.y);
                transform.position = pos;
            }
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (transform.position.x >= endX)
            {
                Vector2 pos = new Vector2(startX, transform.position.y);
                transform.position = pos;
            }
        }
    }
}

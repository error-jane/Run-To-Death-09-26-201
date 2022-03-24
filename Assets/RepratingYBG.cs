using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepratingYBG : MonoBehaviour
{
    public float speed;
    public float endY;
    public float startY;

    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (transform.position.y >= endY)
        {
            Vector2 pos = new Vector2(transform.position.x, startY);
            transform.position = pos;
        }
    }
}

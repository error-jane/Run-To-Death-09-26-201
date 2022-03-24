using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class positionOBJ : MonoBehaviour
{
    public BoxCollider2D bc;
    public int health = 3;
    
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if(health == 2)
            bc.size = new Vector3(2.5f, 1, 1);
        else if(health == 1)
            bc.size = new Vector3(4.5f, 1, 1);
        else if(health == 0)
            bc.size = new Vector3(6.5f, 1, 1);
    }
    

}

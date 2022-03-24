using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCursor : MonoBehaviour
{
    public Animator pop;
    public Animator playButton;

    public Animator OBJ;
    public Animator Rope;

    void Start()
    {
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
      
        if (transform.position.x <= 0 && transform.position.y >= 0 )
        {
            pop.SetBool("popUP",true);

        }
        else
        {
            pop.SetBool("popUP", false);
        }
        if (transform.position.x >= -6.7 && transform.position.x <= -2.8 && transform.position.y >= -4 && transform.position.y <= -2.4)
        {
            playButton.SetBool("play", true);

        }
        else
        {
            playButton.SetBool("play", false);
        }
        if (transform.position.x >= 4.6 && transform.position.x <= 7 && transform.position.y >= -4 && transform.position.y <= 0)
        {
            OBJ.SetBool("HomeOBJ", true);
            Rope.SetBool("rope", true);

        }
        else
        {
            OBJ.SetBool("HomeOBJ", false);
            Rope.SetBool("rope", false);
        }

    }
}

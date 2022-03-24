using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationControll : MonoBehaviour
{
    public Animator playerChoice1;
    public Animator playButton1;
    public Animator RopeChoice1;

    public Animator playerChoice2;
    public Animator playButton2;
    void Start()
    {
        Cursor.visible = false;
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
       
        if (transform.position.x >= 0.6 && transform.position.x <= 8 && transform.position.y >= -4 && transform.position.y <= -2)
        {
            playerChoice1.SetBool("Choice1", true);
            RopeChoice1.SetBool("Choice1", true);
            playButton1.SetBool("Choice1", true);

        }
        else
        {
            playerChoice1.SetBool("Choice1", false);
            RopeChoice1.SetBool("Choice1", false);
            playButton1.SetBool("Choice1", false);
        }
        if (transform.position.x >= -7 && transform.position.x <=-1 && transform.position.y >= -4 && transform.position.y <= -2)
        {
            playerChoice2.SetBool("Choice2", true);
            playerChoice1.SetBool("Choice2", true);
            playButton2.SetBool("Choice2", true);

        }
        else
        {
            playerChoice2.SetBool("Choice2", false);
            playerChoice1.SetBool("Choice2", false);
            playButton2.SetBool("Choice2", false);
        }
        

    }
}

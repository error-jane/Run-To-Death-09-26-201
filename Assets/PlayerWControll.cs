using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerWControll : MonoBehaviour
{
    public GameObject soundBG;

    private float y;
    /*Value for Junmp*/
    private bool isJump;
    public float jumpForce;

    private Rigidbody2D rb;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpValue;
    /*Value for Slide*/
    public BoxCollider2D bc;
    public float speedDown;

    /*Value for animation*/
    public Animator anim;

    public int health = 3;
    public int score = 0;
    public bool win = false;
    private int isFirstTime = 0;

    public GameObject effectJump;
    public GameObject effectDie;

    public Animator transitionAnim;
    public int sceneName;

    public positionOBJ pO;

    public Text scoreDisplay;
    public Animator textAnim;

    private void Start()
    {
        Instantiate(soundBG, transform.position, Quaternion.identity);
        y = transform.position.y;
        isJump = false;
        extraJumps = extraJumpValue;
        rb = GetComponent<Rigidbody2D>();

        bc = bc.GetComponent<BoxCollider2D>();

        anim = GetComponent<Animator>();

        pO = pO.GetComponent<positionOBJ>();
    }
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }
    private void Update()
    {
        scoreDisplay.text = score.ToString()+"/10";
        pO.health = health;
        if (health <= 0 || transform.position.y <= -4 || transform.position.x <= -8)
        {
            if (isFirstTime == 0)
                Instantiate(effectDie, transform.position, Quaternion.identity);
            isFirstTime++;
            anim.SetBool("isSlide", true);
            StartCoroutine(LoadScene());

        }
        if (win == true)
        {
            if (score >= 10)
            {
                transitionAnim.SetTrigger("end");
                textAnim.SetTrigger("endText");
                SceneManager.LoadScene(1);
            }
            else
            {
                transitionAnim.SetTrigger("end");
                textAnim.SetTrigger("endText");
                SceneManager.LoadScene(2);
            }

        }
        if (isGrounded == true)
        {
            y = transform.position.y;
            extraJumps = extraJumpValue;
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
            anim.SetBool("isJumping", true);
        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            Instantiate(effectJump, transform.position, Quaternion.identity);
            
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
            isJump = true;
        }

        if (isGrounded == true && isJump == true)
        {
            anim.SetBool("isJumping", false);
            isJump = false;
        }
      
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            Instantiate(effectJump, transform.position, Quaternion.identity);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("isSlide", true);
            if (transform.position.y > y)
            {
                rb.velocity = new Vector2(0, -speedDown);
            }
            else
            {
                bc.size = new Vector3(0.5f, 0.79f, 1);
                bc.offset = new Vector3(0, 0.3f, 0);
            }
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetBool("isSlide", false);
            bc.size = new Vector3(0.5f, 1, 1);
            bc.offset = new Vector3(0, 0.5f, 0);
        }
    }
    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");
        textAnim.SetTrigger("endText");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
}

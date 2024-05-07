using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool canMove = true;
    [SerializeField]
    private float moveFocre = 10f;
    [SerializeField]
    private float jumpForce = 12f;
    [SerializeField]
    private float movementX;
    private float movementY;
    private Rigidbody2D myBody;
    private SpriteRenderer myRenderer;
    private Animator PlayerAnim;
    public GameObject PlayerText;
    // Start is called before the first frame update
    public void setCanMove(bool b)
    {
        this.canMove = b;
    }

    private bool onGround = true;
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();

        PlayerAnim = GetComponent<Animator>();
        myRenderer = GetComponent<SpriteRenderer>();

        
    }
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();

        PlayerAnim = GetComponent<Animator>();
        myRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            PlayerMoveKeyBoard();
            AnimatePlayer();
             PlayerJump();
        }
        
    }
    private void FixedUpdate()
    {
       
    }
    void PlayerMoveKeyBoard()
    {
        movementX = Input.GetAxis("Horizontal");
  
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveFocre;
        
        PlayerText.transform.position = transform.position + new Vector3(7f,0.3f,0f);

    }
    void AnimatePlayer()
    {
        if (movementX > 0)
        {
            PlayerAnim.SetBool("Run", true);
            myRenderer.flipX = false;
        }
        else if(movementX == 0){
            PlayerAnim.SetBool("Run", false);
           
        }
        else
        {
            PlayerAnim.SetBool("Run", true);
            myRenderer.flipX = true;
        }
    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && onGround)
        {
            PlayerAnim.SetBool("IsJumping", true);
            onGround = false;
            myBody.AddForce(new Vector2(0f,jumpForce), ForceMode2D.Impulse);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
            PlayerAnim.SetBool("IsJumping", false);
        }
    }
}

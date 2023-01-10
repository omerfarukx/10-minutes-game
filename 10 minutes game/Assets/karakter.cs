using UnityEngine;

public class karakter : MonoBehaviour
{
    public float moveSpeed = 600f;

    float movement = 0f;
    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private float  horizontalMove;
    public float speed = 5;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveLeft = false;
        moveRight = false;
    }


    public void PointerDownLeft()
    {
        moveLeft = true;
    }

    public void PointerUpLeft()
    {
        moveLeft = false;
    }
    public void PointerDownRight()
    {
        moveRight = true;
    }
    public void PointerUpRight()
    {
        moveRight = false;
    }
    private void MovementPlayer()
    {
        if (moveLeft)
        {
            movement = -moveSpeed;
        }
        else if (moveRight)
        {
            movement = moveSpeed;
        }
        else
        {
            movement = 0;
        }
    }
    private void Update()
    {
        MovementPlayer();
    }

    private void FixedUpdate()
    {
        
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }
}

using System.Linq;
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    public KeyCode JumpKey;
    public KeyCode LeftKey;
    public KeyCode RightKey;
    public float JumpPower;
    public float HorizontalPower;
    public float HorizontalDragFactor;
    public GameObject[] TerrainCheckers;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //JumpPower = 10.0f;
        //HorizontalPower = 10.0f;
        //HorizontalDragFactor = 1.01f;
        JumpKey = KeyCode.UpArrow;
        LeftKey = KeyCode.LeftArrow;
        RightKey = KeyCode.RightArrow;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        bool touchingGround = TerrainCheckers.Any(o => Physics2D.OverlapPoint(o.transform.position, LayerMask.GetMask("Ground") | LayerMask.GetMask("Player")));
        if (touchingGround)
        {
            Vector3 CurreState = rb.velocity;
            if (Input.GetKey(JumpKey))
            {
                Vector3 Jump = new Vector3(0, JumpPower, 0);
                rb.velocity = CurreState + Jump;
            }
            if (Input.GetKey(LeftKey))
            {
                Vector3 Left = new Vector3(-HorizontalPower, 0, 0);
                rb.velocity = CurreState + Left;
            }
            if (Input.GetKey(RightKey))
            {
                Vector3 Right = new Vector3(HorizontalPower, 0, 0);
                rb.velocity = CurreState + Right;
            }
            rb.velocity = new Vector3(rb.velocity.x / HorizontalDragFactor, rb.velocity.y, 0);
            
        }
    }
    void OnCollision()
    {

    }
}

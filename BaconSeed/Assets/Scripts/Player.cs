using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        if (Input.GetButtonDown("up"))
            rb.velocity = new Vector3(0, 10, 0);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRampSupport : MonoBehaviour
{

    public float moveSpeed = 1f;
    public string inputAxis;
    private float verticalInput;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        verticalInput = Input.GetAxis(inputAxis);
    }
    private void FixedUpdate()
    {
        
        rigidbody.velocity = new Vector2(0, verticalInput * moveSpeed);
    }
}
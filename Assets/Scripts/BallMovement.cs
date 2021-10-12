using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rigidbody;
    private Vector2 moveDirection;
   

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); //a,d kiri kanan
        float moveY = Input.GetAxis("Vertical"); //w,s atas bawah

        moveDirection.Set(moveX, moveY);
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = moveDirection.normalized * speed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float speed = 2f;
    public bool left = true;

    public GroundCheckHitbox check;

    private Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        left = !left;
    }

    private void FixedUpdate()
    {
        if (left == true)
        {
            rbody.MovePosition(rbody.position + (-(Vector2)transform.right * Time.deltaTime));
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            rbody.MovePosition(rbody.position + ((Vector2)transform.right * Time.deltaTime));
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        if (check.isGrounded == false)
        {
            left = !left;
        }
    }
}

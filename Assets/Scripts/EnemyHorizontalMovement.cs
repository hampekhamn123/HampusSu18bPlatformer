using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float speed = 2f;
    public bool left = true;

    private Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (left == true)
        {
            rbody.MovePosition(rbody.position + (-(Vector2)transform.right * Time.deltaTime));
            transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        }
        else
        {
            rbody.MovePosition(rbody.position + ((Vector2)transform.right * Time.deltaTime));
            transform.localScale = new Vector3(-1.5f, 1.5f, 1.5f);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        left = !left;
    }
}

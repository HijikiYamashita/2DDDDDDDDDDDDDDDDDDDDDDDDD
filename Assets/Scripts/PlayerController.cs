using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 moveX = new Vector3(1, 0, 0);
    Vector3 moveY = new Vector3(0, 1, 0);

    public float speed;
    Vector3 target;

    void Start()
    {
        target = transform.position;
    }

    void Update()
    {
        if (transform.position == target)
        {
            SetTargetPosition();
        }
        Move();
    }

    void SetTargetPosition()
    {
        if (Input.GetKey(KeyCode.W))
        {
            target = transform.position + moveY;
        }
        if (Input.GetKey(KeyCode.S))
        {
            target = transform.position - moveY;
        }
        if (Input.GetKey(KeyCode.D))
        {
            target = transform.position + moveX;
        }
        if (Input.GetKey(KeyCode.A))
        {
            target = transform.position - moveX;
        }
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}

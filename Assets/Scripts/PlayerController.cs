using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Vector3 moveX = new Vector3(1, 0, 0);
    Vector3 moveY = new Vector3(0, 1, 0);

    public float speed;
    public Vector3 target;

    float time = 30.0f;
    public Text timeText;

    void Start()
    {
        target = transform.position;
    }

    void Update()
    {
        //transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, -2.5f, 1.5f), Mathf.Clamp(this.transform.position.y, -2.5f, 1.5f), 0);

        if (transform.position == target)
        {
            SetTargetPosition();
        }

        Move();

        time -= Time.deltaTime;
        timeText.text = "残り時間 : " + time.ToString("f1") + " 秒";

        if (time <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ball : MonoBehaviour
{
    public int speed = 30;
    public Rigidbody2D ball;
    public Animator animtor;


    // Start is called before the first frame update
    void Start()
    {
        ball.velocity = new Vector2(-1, -1) * speed;
        animtor.SetBool("isMove", true);
    }




    // Update is called once per frame
    void FixedUpdate()
    {
        if (ball.velocity.x > 0)
        {
            ball.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        }
        else
        {
            ball.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "WallVerticalKanan")
        {
            StartCoroutine(jeda());
        }
        else if (other.collider.name == "WallVerticalKiri")
        {
            StartCoroutine(jeda());
        }


    }


    IEnumerator jeda()
    {
        ball.velocity = Vector2.zero;
        animtor.SetBool("isMove", false);
        GetComponent<Transform>().position = Vector2.zero;
        yield return new WaitForSeconds(1);
        ball.velocity = new Vector2(-1, -1) * speed;
        animtor.SetBool("isMove", true);
    }


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ball : MonoBehaviour
{
    //public int speed = 30;
    public Rigidbody2D ball;
    public Animator animtor;
    public GameObject MasterScript;


    // Start is called before the first frame update
    void Start()
    {
        int x = Random.Range(0, 2) * 2 - 1;
        int y = Random.Range(0, 2) * 2 - 1;
        int speed = Random.Range(20, 26);
        ball.velocity = new Vector2(x, y) * speed;
        ball.GetComponent<Transform>().position = Vector2.zero;
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
        if (other.collider.name == "WallVerticalKanan"||other.collider.name == "WallVerticalKiri")
        {
            MasterScript.GetComponent<ScoringScript>().UpdateScore(other.collider.name);
            StartCoroutine(jeda());
        }


    }


    IEnumerator jeda()
    {
        ball.velocity = Vector2.zero;
        animtor.SetBool("isMove", false);
        GetComponent<Transform>().position = Vector2.zero;
        
        yield return new WaitForSeconds(1);
        int x = Random.Range(0, 2) * 2 - 1;
        int y = Random.Range(0, 2) * 2 - 1;
        int speed = Random.Range(20, 26);
        ball.velocity = new Vector2(x, y) * speed;
        animtor.SetBool("isMove", true);
    }


}
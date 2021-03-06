﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int counter = 30;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = counter.ToString();
        StartCoroutine(hitungMundur());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator hitungMundur() {
        while (counter > 0)
        {
            yield return new WaitForSeconds(1);
            counter -= 1;
            timerText.text = counter.ToString();
        }

        SceneManager.LoadScene("GameOverS");
    }
}

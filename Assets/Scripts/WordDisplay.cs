﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WordDisplay : MonoBehaviour {

    public Text text;
    public float fallspeed = 1f;
    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemovalLetter()
    {
        text.text = text.text.Remove(0,1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f,-fallspeed * Time.deltaTime,0f);
        if (transform.position.y < -5f)
        {
            FindObjectOfType<WordManager>().ShowRestart();
        }
    }

}

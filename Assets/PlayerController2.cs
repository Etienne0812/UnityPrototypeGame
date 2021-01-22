﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour
{
    public PlayerMovement2 movement2;
    public GameObject goldcap;
    private int points;
    private int coincount;
    private int collectibles;
    public Text pointCountText;
    public Text collectibleText;
    public Text winText;
    public GameObject HomeButton;
    public GameObject RetryButton;
    private bool goldIsTouched;
    void Start()
    {
        points = 0;
        collectibles = 0;
        coincount = 0;
        goldIsTouched = false;
        SetPointCountText();
        SetCollectibleText();
        goldcap.SetActive(false);
        HomeButton.SetActive(false);
        RetryButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        SetGoldCap();
    }

    void OnTriggerEnter (Collider other) {
        if(other.gameObject.CompareTag("Coin")){
            other.gameObject.SetActive(false);
            points += 100;
            coincount++;
            SetPointCountText();
        } 

        if(other.gameObject.CompareTag("Cap")){
            other.gameObject.SetActive(false);
            points += 300;
            collectibles++;
            SetPointCountText();
            SetCollectibleText();
        }

        if(other.gameObject.CompareTag("GoldCap")){
            other.gameObject.SetActive(false);
            points += 300;
            collectibles++;
            SetPointCountText();
            SetCollectibleText();
            goldIsTouched = true;
        }

        if(other.gameObject.CompareTag("Finish")){
            points += 500;
            SetPointCountText();
            winText.text = "Level Cleared!";
            movement2.enabled = false;
            HomeButton.SetActive(true);
            
        }
    }

    void OnCollisionEnter (Collision ColInfo) {
        if (ColInfo.collider.tag == "Obstacle"){
            movement2.enabled = false;
            winText.text = "Level Failed!";
            RetryButton.SetActive(true);
        }
    }

    void SetPointCountText(){
        pointCountText.text = "Points: " + points.ToString();
    }

    void SetCollectibleText(){
        collectibleText.text = collectibles.ToString() + "/6 collectibles picked";
    }

    void SetGoldCap(){
        if(coincount > 14 && goldIsTouched == false){
            goldcap.SetActive(true);
        }
    }
}

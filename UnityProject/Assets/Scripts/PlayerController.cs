using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    /* This script controls how the Pterodactyl is controlled by the player. The TorqueForce enables the sprite to spin AND slow down. I decided
     * to use TorqueForce instead of an animation to make the spinning challenging, yet rewarding; also allowing for different spinning speeds.*/
    public Rigidbody2D rigidBody;
    public float TorqueForce = 10.0f;
    public Text scoreText;

    public int score;


    void Start()
    {
        score = 0;
        UpdateScore ();
    
    }

    private void OnMouseUpAsButton()
    {
        rigidBody.AddTorque(TorqueForce);
        AddScore(1);
      
    }

    /* This part of the code basically controls the scorekeeping side of things. It will keep track of how many times the player has clicked
     the sprite, and represent it with text.*/
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore ()
    {
        scoreText.text = "Clicks: " + score;
    }
}


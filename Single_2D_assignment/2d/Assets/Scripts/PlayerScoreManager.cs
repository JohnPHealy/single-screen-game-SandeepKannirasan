using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;


    private void Update()
    {
        scoreDisplay.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemybullet"))
        {
            score--;

            Destroy(other.gameObject);

         if(score <= 0)
            {
                SceneManager.LoadScene( 0 );
            }
        }
    }
}


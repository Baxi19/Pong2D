using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DeadZone : MonoBehaviour
{

    public Text scorePlayerText;
    public Text scoreEnemyText;

    int scorePlayerQuantity=0;
    int scoreEnemyQuantity=0;

    private void OnTriggerEnter2D(Collider2D other) {
        if(gameObject.tag.Equals("Right")){
            scorePlayerQuantity++;
            UpdateScore(scorePlayerText, scorePlayerQuantity);
            
        } else if(gameObject.tag.Equals("Left")){
            scoreEnemyQuantity++;
            UpdateScore(scoreEnemyText, scoreEnemyQuantity);
            
        }
    }

    void UpdateScore(Text scoreText, int quantity){
        scoreText.text = quantity.ToString(); 
    }
}

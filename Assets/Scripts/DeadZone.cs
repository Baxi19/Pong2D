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

    public SceneChanger sceneChanger; 
    public AudioSource pointAudio;

    private void OnTriggerEnter2D(Collider2D ball) {
        //if the player scores
        if(gameObject.tag.Equals("Right")){
            pointAudio.Play();
            scorePlayerQuantity++;
            UpdateScore(scorePlayerText, scorePlayerQuantity);
            
        }
        //if the enemy scores
        else if(gameObject.tag.Equals("Left")){
            //Sound active if someone scores
            pointAudio.Play();
            scoreEnemyQuantity++;
            UpdateScore(scoreEnemyText, scoreEnemyQuantity);
        }

        //Restart game
        ball.GetComponent<BallBehaviour>().gameStarted = false;
        CheckScore();
    }

    //check if someone wins
    void CheckScore(){
        if(scorePlayerQuantity >= 3){
            sceneChanger.changeSceneTo("WinScene");
        }else if(scoreEnemyQuantity >= 3){
            sceneChanger.changeSceneTo("LostScene");
        }
    }

    //Update UI
    void UpdateScore(Text scoreText, int quantity){
        scoreText.text = quantity.ToString(); 
    }
}

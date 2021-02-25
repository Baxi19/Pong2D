using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeadZone : MonoBehaviour
{
    private void onCollisionEnter2D(Collision2D collision){
        Debug.Log("Collision");
    }

    private void onTriggerEnter2D(Collider2D collision){
        Debug.Log("Trigger");
    }
}

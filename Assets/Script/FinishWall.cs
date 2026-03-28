using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishWall : MonoBehaviour
{
   public string nextScene;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Level Completed!");
            GameManager.instance.WinGame();
        }
    }   
}

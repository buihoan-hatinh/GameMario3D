using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.instance.GameOver();

        }
    }
}
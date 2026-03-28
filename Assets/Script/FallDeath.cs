using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDeath : MonoBehaviour
{
    public float deathY = -2f; 

    void Update()
    {
        if (transform.position.y < deathY)
        {
            GameManager.instance.GameOver();
        }
    }
}
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public float time = 60f;

    void Update()
    {
        time -= Time.deltaTime;
        timeText.text = "Time: " + Mathf.Ceil(time);

        if (time <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
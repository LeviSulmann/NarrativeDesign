using UnityEngine;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    public float totalTime = 60.0f; // The total time for the countdown
    private float timeRemaining; // The remaining time for the countdown
    private TextMeshProUGUI countdownText; // The TextMeshPro component for displaying the countdown

    void Start()
    {
        timeRemaining = totalTime;
        countdownText = GetComponent<TextMeshProUGUI>();

    }

    void Update()
    {
        timeRemaining -= Time.deltaTime;

        int minutes = Mathf.FloorToInt(timeRemaining / 60.0f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60.0f);

        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timeRemaining <= 0.0f)
        {
            // Handle the countdown timer finishing
        }
    }
}
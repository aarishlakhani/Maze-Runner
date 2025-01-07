using UnityEngine;

public class GameTimer : MonoBehaviour
{
    private float currentTime = 0f;
    private bool isTimerRunning = true; // To control the timer state

    void Update()
    {
        if (isTimerRunning)
        {
            currentTime += Time.deltaTime; // Increment time
        }
    }

    void OnGUI()
    {
        // Calculate minutes and seconds from the current time
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);

        // Display the timer in the top-right corner
        GUI.Label(new Rect(Screen.width - 100, 10, 90, 30), $"Time: {minutes:00}:{seconds:00}");
    }

    public void StopTimer() // Method to stop the timer
    {
        isTimerRunning = false;
    }

    public float GetCurrentTime() // Method to get the current time
    {
        return currentTime;
    }
}
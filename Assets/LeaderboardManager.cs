using UnityEngine;
using TMPro;

public class LeaderboardManager : MonoBehaviour
{
    public TMP_Text leaderboardText;

    void Start()
    {
        string records = PlayerPrefs.GetString("LeaderboardRecords", "");
        if (!string.IsNullOrEmpty(records))
        {
            string[] entries = records.Split(',');
            string displayText = "Leaderboard:\n";
            
            foreach (string entry in entries)
            {
                string[] parts = entry.Split(':');
                if (parts.Length == 2 && float.TryParse(parts[1], out float recordedTime))
                {
                    displayText += $"{parts[0]} - {FormatTime(recordedTime)}\n";
                }
            }

            leaderboardText.text = displayText;
        }
        else
        {
            leaderboardText.text = "No records available.";
        }
    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
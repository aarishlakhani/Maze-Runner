using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerNameSubmitter : MonoBehaviour
{
    public TMP_InputField nameInputField;

    public void SubmitPlayerName()
    {
        string playerName = nameInputField.text;

        // Ensure name is 3 characters, filling or truncating if necessary
        playerName = playerName.PadRight(3).Substring(0, 3);
        float currentTime = PlayerPrefs.GetFloat("CurrentTime");

        // Get and append new name/time record to stored data
        string records = PlayerPrefs.GetString("LeaderboardRecords", "");
        string newRecord = $"{playerName}:{currentTime}";
        records = string.IsNullOrEmpty(records) ? newRecord : records + "," + newRecord;

        // Save updated leaderboard records
        PlayerPrefs.SetString("LeaderboardRecords", records);
        SceneManager.LoadScene(2); // Load the Leaderboard scene (index 2)
    }
}
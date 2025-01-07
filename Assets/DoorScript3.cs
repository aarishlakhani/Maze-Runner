using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorScript3 : MonoBehaviour
{
    public static bool doorKey;
    public bool open;
    public bool close;
    public bool inTrigger;

    private Vector3 doorPosition = new Vector3(7.58f, -1.7084f, -0.25f);
    private bool showEndMessage = false;

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    void Update()
    {
        if (inTrigger)
        {
            if (close)
            {
                if (doorKey)
                {
                    if (Input.GetKeyDown(KeyCode.T))
                    {
                        open = true;
                        close = false;
                        showEndMessage = true;

                        // Capture the time from GameTimer
                        float currentTime = FindObjectOfType<GameTimer>().GetCurrentTime();

                        // Store the current time in PlayerPrefs
                        PlayerPrefs.SetFloat("CurrentTime", currentTime);

                        // Start coroutine to load the SubmitName scene
                        StartCoroutine(LoadSubmitNameSceneAfterDelay());
                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    close = true;
                    open = false;
                }
            }
        }

        // Rotate the door
        if (open)
        {
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 200);
            transform.rotation = newRot;
        }
        else
        {
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 200);
            transform.rotation = newRot;
        }
    }

    void OnGUI()
    {
        if (inTrigger)
        {
            if (open)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Press T to close");
            }
            else
            {
                if (doorKey)
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Press T to open");
                }
                else
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Need a key!");
                }
            }
        }

        // Display "THE END" message when the door is open
        if (showEndMessage)
        {
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(doorPosition);
            GUI.Label(new Rect(screenPosition.x - 50, Screen.height - screenPosition.y - 30, 100, 50), "THE END");
        }
    }

    // Coroutine to load SubmitName scene after a delay
    IEnumerator LoadSubmitNameSceneAfterDelay()
    {
        yield return new WaitForSeconds(2f); // Wait for 2 seconds
        SceneManager.LoadScene("SubmitName"); // Load SubmitName scene by name
    }
}

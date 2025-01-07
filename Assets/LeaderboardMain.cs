using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaderboardMain : MonoBehaviour
{
    // Start is called before the first frame update
    public void BacktoMain()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
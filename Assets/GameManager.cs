using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

  

    public int restartDelay = 1;
    public void EndGame()
    {
        Invoke("Restart", restartDelay);
        YellowScore.scoreValue = 0;
        BlueScore.scoreValue = 0;
        GreenScore.scoreValue = 0;
        TotalScore.scoreValue = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

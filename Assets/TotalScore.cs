using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalScore : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Total Score:  " + (YellowScore.scoreValue + GreenScore.scoreValue + BlueScore.scoreValue);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

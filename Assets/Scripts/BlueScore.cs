using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueScore : MonoBehaviour
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
        score.text = "Blue: " + scoreValue;

    }
}

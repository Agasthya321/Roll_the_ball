using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenScore : MonoBehaviour
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
        score.text = "Green: " + scoreValue;

    }
}

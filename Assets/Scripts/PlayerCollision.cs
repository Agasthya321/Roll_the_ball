using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public float restartDelay = 3f;


    void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.tag == "Yellow")
        {
            YellowScore.scoreValue += 1;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Blue")
        {
            BlueScore.scoreValue += 2;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Green")
        {
            GreenScore.scoreValue += 3;
            Destroy(col.gameObject);
        }

        if (GameObject.Find("GreenCube#1(Clone)") == null && GameObject.Find("YellowCube#1(Clone)") == null && GameObject.Find("BlueCube#1(Clone)") == null)
        {
            
            FindObjectOfType<GameManager>().EndGame();

        }
        
       


    }

    

}

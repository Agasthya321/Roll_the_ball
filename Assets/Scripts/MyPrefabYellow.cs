using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPrefabYellow : MonoBehaviour
{
    private GameObject cube;
    private GameObject cube1;
    private GameObject cube2;
    private GameObject cube3;
    private GameObject cube4;
    private GameObject cube5;
    private GameObject cube6;

    public GameObject cubePreFab;


    void Start()
    {
        Vector3 offset = new Vector3(0, 0, 0);
        Vector3 offset1 = new Vector3(15, 0, 0);
        Vector3 offset2 = new Vector3(7, 0, 10);
        Vector3 offset3 = new Vector3(-3, 0, 22);
        Vector3 offset4 = new Vector3(0, 0, -14);
        Vector3 offset5 = new Vector3(25, 0, -14);
        Vector3 offset6 = new Vector3(25, 0, 22);

        //for(int i = 0; i<4; i++)
        // {
        cube = Instantiate(cubePreFab);
        cube1 = Instantiate(cubePreFab);
        cube2 = Instantiate(cubePreFab);
        cube3 = Instantiate(cubePreFab);
        cube4 = Instantiate(cubePreFab);
        cube5 = Instantiate(cubePreFab);
        cube6 = Instantiate(cubePreFab);


        cube.transform.position = cube.transform.position + offset;
        cube1.transform.position = cube.transform.position + offset1;
        cube2.transform.position = cube.transform.position + offset2;
        cube3.transform.position = cube.transform.position + offset3;
        cube4.transform.position = cube.transform.position + offset4;
        cube5.transform.position = cube.transform.position + offset5;
        cube6.transform.position = cube.transform.position + offset6;


    }

}
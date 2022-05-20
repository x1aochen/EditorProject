using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiResources : MonoBehaviour
{

    //加载两个预制体
    void Start()
    {
        Object cube = Resources.Load("Cube");
        GameObject obj1 = Instantiate(cube) as GameObject;
        obj1.name = "cube";

        Object capsule = Resources.Load("Capsule");
        GameObject obj2 = Instantiate(capsule) as GameObject;
        obj2.name = "capsule";

    }
}

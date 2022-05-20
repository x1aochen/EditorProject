using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]//在编辑模式下可以执行一些生命周期函数
public class NodeManager : MonoBehaviour {

    //存储了所有编辑器下点击生成的点，并使用预制体显示
    public List<GameObject> nodes;

    private void Start()
    {
        nodes = new List<GameObject>();
    }

    void Update () 
    {

        for (int i = 0; i < nodes.Count - 1; i++)
        {
            Debug.DrawLine(nodes[i].transform.position, 
                nodes[i + 1].transform.position, 
                Color.red,
                Time.deltaTime);
            //因为游戏没运行，Time.deltaTime为无限长
        }
	}
}

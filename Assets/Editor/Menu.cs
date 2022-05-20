using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//顶部菜单类
public class Menu
{
    //在顶部显示"工具"菜单，下方有"导出AB资源包"，点击执行函数
    [MenuItem("工具/导出AB资源包")]
    static void BuildAB()
    {
        //Debug.Log("导出AB资源包");
        Debug.Log(Application.persistentDataPath);
    }
}

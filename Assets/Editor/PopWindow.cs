using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PopWindow : EditorWindow
{
    [MenuItem("工具/创建窗口")]
    static void OpenWindow()
    {
        PopWindow window = GetWindow<PopWindow>(false, "弹窗标题", true);
        window.minSize = new Vector2(40, 30);
        window.minSize = new Vector2(80, 60);
    }

    //开窗口调用
    private void OnEnable()
    {
        Debug.Log("enable");
    }

    //关窗口调用
    private void OnDisable()
    {
        Debug.Log("disable");
    }

    //窗口开启就调用
    private void Update()
    {
        Debug.Log("update");
    }

    private void OnGUI()
    {
        if (GUILayout.Button("测试点击"))
        {
            Debug.Log("测试点击");
        }
    }

    //场景结构发生变化，执行回调函数
    private void OnHierarchyChange()
    {
        Debug.Log("hierarchy");
    }

    //项目结构发生变化，执行回调函数
    private void OnProjectChange()
    {
        Debug.Log("project");
    }

    //选中物体发生变化，执行回调函数
    private void OnSelectionChange()
    {
        //获取当前选中的物体的名称
        Debug.Log(Selection.activeGameObject.name);
    }
}

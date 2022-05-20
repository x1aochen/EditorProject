using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//单选我们使用十进制理解，即不同数代表不同选项
public enum PlayerProfression
{
    Warrior = 0,
    Wizard = 1,
}

//多选使用二进制理解，即不同位代表不同选项
public enum PlayerLoveColor
{
    Green = 1,
    Red = 2,
    Pink = 4,
}

//将Player组件添加到AddComponent上
//第一个参数：分类名/组件名
//第二个参数：列表中显示的顺序
[AddComponentMenu("自定义控制器/玩家控制器", 1)]
//使生命周期函数，在编辑器状态下可以执行，游戏中也可以正常使用
//Update()在场景中对象发生变化或项目组织发生变化时会在编辑器下执行
[ExecuteInEditMode]
//关于类型和类名
//BoxCollider：是类名，适用于函数提供泛型方法
//typeof(BoxCollider)：System.Type，C#的类型，适用于函数需要System.Type参数
//当前组件依赖于盒子碰撞体
//当前组件挂载在对象上时，盒子碰撞体会一起被添加上去
//当Player组件没有被移除时，盒子碰撞体不能被删除
[RequireComponent(typeof(BoxCollider))]
public class Player : MonoBehaviour
{
    public int ID;

    public string Name;

    public float Atk;

    public bool isMan;

    public Vector3 HeadDir;

    public Color Hair;

    public GameObject Weapon;

    public Texture Cloth;

    public PlayerProfression Pro;

    public PlayerLoveColor LoveColor;

    public List<string> Items;

    void Update()
    {
        //Debug.Log("Update");
    }
}

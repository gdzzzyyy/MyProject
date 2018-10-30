using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// UI 管理器
/// 拟规划：1. UI池子的作用 常驻UI 和 随调随用UI
/// 2. 打开和关闭UI
/// 3 UI层级问题。 类似数据结构里面的堆栈  先进后出的模式   让后进入的UI压入栈中，先从后进入的UI开始卸载，最后卸载最开始的UI  保证顺序
/// 4. 在UI池子里增加黑白名单 ， 关闭的时候全部关闭 或者有目标队列性的关闭
/// </summary>

public class UIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

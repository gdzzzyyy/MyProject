using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 战斗场景的玩家信息
/// 1. 玩家属性 血量 当前骰子数   当前携带卡堆
/// 2. 玩家特殊技能
/// </summary>
public class BattleActorInfo  {
    public BattleActorInfo() { }

    public int m_ActorID;//人物id
    public int m_ActorHp;//血量
    public int m_ActorMp;// 不一定需要
    
}

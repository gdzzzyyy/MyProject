using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

class BattleMainFlow
{

    public static BattleMainFlow MainFlowInstance = null;

    private BattleMainFlow ()
    {

    }

    public static BattleMainFlow GetInstance()
    {
        if(MainFlowInstance == null)
        {
            MainFlowInstance = new BattleMainFlow();
        }

        return MainFlowInstance;
    }


    public CommonEnum.BattleStateEnum m_mainState = CommonEnum.BattleStateEnum.BATTLE_BEGIN; //主状态机状态
    public CommonEnum.BattleStateEnum m_curMainState = CommonEnum.BattleStateEnum.BATTLE_BEGIN; //当前状态机状态
    private float m_waitTime = 0f; //等待时间
    private float m_userCountTime = 15f;
    

    public void MainStateUpdate(float dt)
    {
        switch (m_mainState)
        {
            case CommonEnum.BattleStateEnum.BATTLE_BEGIN:
                {
                    m_curMainState = m_mainState;
                    break;
                };
            case CommonEnum.BattleStateEnum.BATTLE_USER_DO:
                {
                    if((m_waitTime += dt) > m_userCountTime)
                    {
                        m_waitTime = 0;
                        Debug.Log("超时，出牌权交给敌人！");
                        m_mainState = CommonEnum.BattleStateEnum.BATTLE_MONSTER_DO;
                        break;
                    }
                    m_curMainState = m_mainState;

                    break;
                };
            case CommonEnum.BattleStateEnum.BATTLE_MONSTER_DO:
                {
                    if ((m_waitTime += dt) > m_userCountTime)
                    {
                        Debug.Log("超时，出牌权交给敌人！");
                        m_mainState = CommonEnum.BattleStateEnum.BATTLE_MONSTER_DO;
                        break;
                    }
                    m_curMainState = m_mainState;

                    break;
                };
            case CommonEnum.BattleStateEnum.BATTLE_END:
                {
                    m_curMainState = m_mainState;
                    break;
                };
            default:
                {
                    Debug.LogError("MainFlow is Error" + m_mainState);
                    break;
                }
        }

    }

}

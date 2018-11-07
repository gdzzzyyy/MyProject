using System.Collections;
using System.Collections.Generic;
using System;

/// <summary>
/// 卡牌系统   管理所有的卡牌  其实就是技能系统  
/// 技能判断条件和释放条件
/// 参考一般游戏的技能系统
/// 后续有需求再改成有动作的战斗
/// 
/// </summary>
public class CardManager  {
    public static CardManager CardMgrInstance = null;


    private CardManager ()
    {

    }

    public static CardManager GetInstance()
    {
        if(CardMgrInstance == null)
        {
            CardMgrInstance = new CardManager();
        }

        return CardMgrInstance;
    }


	
}

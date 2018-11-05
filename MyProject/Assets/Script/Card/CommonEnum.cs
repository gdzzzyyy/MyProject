using System;

public class CommonEnum
{

    public enum BattleStateEnum
    {
        BATTLE_BEGIN = 0,
        BATTLE_USER_DO = 1,
        BATTLE_MONSTER_DO = 2,
        BATTLE_END = 3,
    }

    public enum ActorState
    {
        STATE_IDEL = 0, //普通状态
        STATE_ROLL = 1, //roll点状态
        STATE_PLAN = 2, //出牌状态
    }

    //轮到哪一个用户行为
    public enum PlayOrder
    {
        ORDER_NULL = 0,
        ORDER_MASTER = 1,
        ORDER_COMPUTER = 2,
        ORDER_OTHER_PLAYER = 3,
    }

    //身上挂的buff枚举
    public enum ActorBuff
    {
        BUFF_NULL = 0,
    }

    //可用骰子数
    public enum USE_ROLL
    {
        ROLL_NULL = 0,
        ROLL_ONE = 1,
        ROLL_TWO = 2,
        ROLL_THREE = 3,
        ROLL_FOUR = 4,
    }
}

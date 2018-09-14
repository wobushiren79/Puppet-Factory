using UnityEngine;
using UnityEditor;

public class CreatureMovementController : BaseMVCController<CreatureMovementModel, CreatureMovementView>
{

    public override void initData()
    {
       
    }

    /// <summary>
    /// 角色移动
    /// </summary>
    /// <param name="direction">方向</param>
    public void creatureMove(Vector3 direction)
    {
        //调取model获取移动速度数据
        long moveSpeed = mModel.getCreatureMoveSpeed();
        //调取view移动物体
        mView.creatureMove(direction, moveSpeed);
    }

    /// <summary>
    /// 角色跳跃
    /// </summary>
    public void creatureJump()
    {
        //调取model获取跳跃力度数据
        long jumpEfforts = mModel.getCreatureJumpEfforts();
        //调取view跳跃物体
        mView.creatureJump(jumpEfforts);
    }


}
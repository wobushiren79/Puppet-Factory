using UnityEngine;
using UnityEditor;

public class CreatureMovementController : BaseMVCController<CreatureMovementModel, CreatureMovementView>
{
    public CreatureMovementController(BaseMonoBehaviour content) : base(content)
    {
    }

    public override void InitData()
    {

    }

    /// <summary>
    /// 角色移动
    /// </summary>
    /// <param name="direction">方向</param>
    public void CreatureMove(Vector3 direction)
    {
        //调取model获取移动速度数据
        long moveSpeed = GetModel().GetCreatureMoveSpeed();
        //调取model获取转身速率
        float rotationRate = GetModel().GetCreatureRotationRate();
        //调取view移动物体
        GetView().CreatureMove(direction, moveSpeed, rotationRate);
    }

    /// <summary>
    /// 角色跳跃
    /// </summary>
    public void CreatureJump()
    {
        //调取model获取跳跃力度数据
        long jumpEfforts = GetModel().GetCreatureJumpEfforts();
        //调取view跳跃物体
        GetView().CreatureJump(jumpEfforts);
    }


}
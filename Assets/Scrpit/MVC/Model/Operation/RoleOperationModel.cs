using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleOperationModel : BaseMVCModel {

    public override void InitData()
    {
    
    }

    /// <summary>
    /// 获取左右移动按键指令
    /// </summary>
    /// <returns></returns>
    public string GetMoveHorizontalAxes()
    {
        return "Move_Horizontal";
    }

    /// <summary>
    /// 获取上下移动按键指令
    /// </summary>
    /// <returns></returns>
    public string GetMoveVerticalAxes()
    {
        return "Move_Vertical";
    }

    /// <summary>
    /// 获取角色跳跃按键指令
    /// </summary>
    /// <returns></returns>
    public string GetJumpAxes()
    {
        return "Role_Jump";
    }

    /// <summary>
    /// 获取角色交互交互指令
    /// </summary>
    /// <returns></returns>
    public string GetInteractAxes() {
        return "Role_Interact";
    }


}

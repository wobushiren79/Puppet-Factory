using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleOperationModel : BaseMVCModel {

    public override void initData()
    {
 
    }

    /// <summary>
    /// 获取左右移动按键指令
    /// </summary>
    /// <returns></returns>
    public string getMoveHorizontalAxes()
    {
        return "Move_Horizontal";
    }

    /// <summary>
    /// 获取上下移动按键指令
    /// </summary>
    /// <returns></returns>
    public string getMoveVerticalAxes()
    {
        return "Move_Vertical";
    }

    /// <summary>
    /// 获取角色跳跃指令
    /// </summary>
    /// <returns></returns>
    public string getJumpAxes()
    {
        return "Role_Jump";
    }


}

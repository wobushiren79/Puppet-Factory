using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleOperationCpt : BaseComponent<RoleOperationModel, RoleOperationView, RoleOperationController>
{

    /// <summary>
    /// 检测输入
    /// </summary>
    private void Update()
    {
        //角色移动监控
        mController.roleMove();
        //角色跳跃监控
        mController.roleJump();
        //角色交互监控
        mController.roleInteract();
    }
}

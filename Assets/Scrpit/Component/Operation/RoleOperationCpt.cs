using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleOperationCpt : BaseComponent
{
    private RoleOperationController mRoleOperationController;

    private void Awake()
    {
        mRoleOperationController = new RoleOperationController(this);
    }

    /// <summary>
    /// 检测输入
    /// </summary>
    private void Update()
    {
        //角色移动监控
        mRoleOperationController.RoleMove();
        //角色跳跃监控
        mRoleOperationController.RoleJump();
        //角色交互监控
        mRoleOperationController.RoleInteract();
    }
}

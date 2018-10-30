using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleOperationController : BaseMVCController<RoleOperationModel, RoleOperationView>
{
    public RoleOperationController(BaseMonoBehaviour content) : base(content)
    {

    }

    public override void InitData()
    {

    }
    /// <summary>
    /// 角色移动操作
    /// </summary>
    public void RoleMove()
    {
        if (Input.GetButton(GetModel().GetMoveHorizontalAxes()))
        {
            //LogUtil.Log("左右移动按钮持续点击");
            //获取变化值
            float moveAxis = Input.GetAxis(GetModel().GetMoveHorizontalAxes());
            //LogUtil.Log("左右移动变化值：" + moveAxis);
            if (moveAxis > 0)
                GetView().MoveRight(moveAxis);//右移动 
            else if (moveAxis < 0)
                GetView().MoveLeft(moveAxis);//左移动 
        }
        if (Input.GetButton(GetModel().GetMoveVerticalAxes()))
        {
            //LogUtil.Log("上下按钮持续点击");
            //获取变化值
            float moveAxis = Input.GetAxis(GetModel().GetMoveVerticalAxes());
            //LogUtil.Log("上下移动变化值：" + moveAxis);
            if (moveAxis > 0)
                GetView().MoveForward(moveAxis);//前移动 
            else if (moveAxis < 0)
                GetView().MoveBackward(moveAxis);//后移动 
        }
    }

    /// <summary>
    /// 角色跳跃操作
    /// </summary>
    public void RoleJump()
    {
        if (Input.GetButtonDown(GetModel().GetJumpAxes()))
        {
            //LogUtil.Log("跳跃按钮点击");
            GetView().Jump();//跳跃
        }
    }

    /// <summary>
    /// 角色互动操作
    /// </summary>
    public void RoleInteract()
    {
        if (Input.GetButtonDown(GetModel().GetInteractAxes()))
        {
            LogUtil.Log("交互按钮点击");
            GetView().Interact();
        }
    }


}

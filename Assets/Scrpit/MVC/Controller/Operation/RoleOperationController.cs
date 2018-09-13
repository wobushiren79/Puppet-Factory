using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleOperationController : BaseMVCController<RoleOperationModel, RoleOperationView>
{

    /// <summary>
    /// 角色移动操作
    /// </summary>
    public void roleMove()
    {
        if (Input.GetButton(mModel.getMoveHorizontalAxes()))
        {
            LogUtil.Log("左右移动按钮持续点击");
            //获取变化值
            float moveAxis = Input.GetAxis(mModel.getMoveHorizontalAxes());
            LogUtil.Log("左右移动变化值：" + moveAxis);
            if (moveAxis > 0)
                mView.moveRight(moveAxis);//右移动 
            else if (moveAxis < 0)
                mView.moveLeft(moveAxis);//左移动 
        }
        if (Input.GetButton(mModel.getMoveVerticalAxes()))
        {
            LogUtil.Log("上下按钮持续点击");
            //获取变化值
            float moveAxis = Input.GetAxis(mModel.getMoveVerticalAxes());
            LogUtil.Log("上下移动变化值：" + moveAxis);
            if (moveAxis > 0)
                mView.moveUp(moveAxis);//上移动 
            else if (moveAxis < 0)
                mView.moveDown(moveAxis);//下移动 
        }
    }

    /// <summary>
    /// 角色跳跃操作
    /// </summary>
    public void roleJump()
    {
        if (Input.GetButtonDown(mModel.getJumpAxes()))
        {
            LogUtil.Log("跳跃按钮点击");
            mView.jump();//跳跃
        }
    }

    /// <summary>
    /// 角色互动操作
    /// </summary>
    public void roleInteract()
    {

    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleOperationView : BaseMVCView
{
    //移动组件
    CreatureMovementCpt mMovementCpt;

    public override void InitData()
    {
        mMovementCpt = GetContent().GetComponent<CreatureMovementCpt>();
    }

    /// <summary>
    /// 向左移动操作
    /// </summary>
    /// <param name="moveAxis"></param>
    public void MoveLeft(float moveAxis)
    {
        BaseMove(DirectionEnum.Left);
    }

    /// <summary>
    /// 向右移动操作
    /// </summary>
    /// <param name="moveAxis"></param>
    public void MoveRight(float moveAxis)
    {
        BaseMove(DirectionEnum.Right);
    }

    /// <summary>
    /// 向上移动操作
    /// </summary>
    /// <param name="moveAxis"></param>
    public void MoveForward(float moveAxis)
    {
        BaseMove(DirectionEnum.Forward);
    }

    /// <summary>
    /// 向下移动操作
    /// </summary>
    /// <param name="moveAxis"></param>
    public void MoveBackward(float moveAxis)
    {
        BaseMove(DirectionEnum.Backward);
    }

    /// <summary>
    /// 跳跃操作
    /// </summary>
    public void Jump()
    {
        if (!mMovementCpt)
        {
            LogUtil.Log("操作无效：对象没有CreatureMovement组件");
            return;
        }
        mMovementCpt.CreatureJump();
    }
    
    /// <summary>
    /// 交互操作
    /// </summary>
    public void Interact()
    {

    }


    /// <summary>
    /// 基础移动
    /// </summary>
    private void BaseMove(DirectionEnum direction)
    {
        if (!mMovementCpt)
        {
            LogUtil.Log("操作无效：对象没有CreatureMovement组件");
            return;
        }
        switch (direction) {
            case DirectionEnum.Left:
                mMovementCpt.CreatureMoveLeft();
                break;
            case DirectionEnum.Right:
                mMovementCpt.CreatureMoveRight();
                break;
            case DirectionEnum.Forward:
                mMovementCpt.CreatureMoveForward();
                break;
            case DirectionEnum.Backward:
                mMovementCpt.CreatureMoveBackward();
                break;
        }
    }

}

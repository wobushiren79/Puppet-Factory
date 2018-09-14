using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleOperationView : BaseMVCView
{
    //移动组件
    CreatureMovementCpt mMovementCpt;

    public override void initData()
    {
        mMovementCpt = getContent().GetComponent<CreatureMovementCpt>();
    }

    /// <summary>
    /// 向左移动操作
    /// </summary>
    /// <param name="moveAxis"></param>
    public void moveLeft(float moveAxis)
    {
        baseMove(DirectionEnum.left);
    }

    /// <summary>
    /// 向右移动操作
    /// </summary>
    /// <param name="moveAxis"></param>
    public void moveRight(float moveAxis)
    {
        baseMove(DirectionEnum.right);
    }

    /// <summary>
    /// 向上移动操作
    /// </summary>
    /// <param name="moveAxis"></param>
    public void moveForward(float moveAxis)
    {
        baseMove(DirectionEnum.forward);
    }

    /// <summary>
    /// 向下移动操作
    /// </summary>
    /// <param name="moveAxis"></param>
    public void moveBackward(float moveAxis)
    {
        baseMove(DirectionEnum.backward);
    }

    /// <summary>
    /// 跳跃操作
    /// </summary>
    public void jump()
    {
        if (!mMovementCpt)
        {
            LogUtil.Log("操作无效：对象没有CreatureMovement组件");
            return;
        }
        mMovementCpt.creatureJump();
    }
    
    /// <summary>
    /// 交互操作
    /// </summary>
    public void interact()
    {

    }


    /// <summary>
    /// 基础移动
    /// </summary>
    private void baseMove(DirectionEnum direction)
    {
        if (!mMovementCpt)
        {
            LogUtil.Log("操作无效：对象没有CreatureMovement组件");
            return;
        }
        switch (direction) {
            case DirectionEnum.left:
                mMovementCpt.creatureMoveLeft();
                break;
            case DirectionEnum.right:
                mMovementCpt.creatureMoveRight();
                break;
            case DirectionEnum.forward:
                mMovementCpt.creatureMoveForward();
                break;
            case DirectionEnum.backward:
                mMovementCpt.creatureMoveBackward();
                break;
        }
    }

}

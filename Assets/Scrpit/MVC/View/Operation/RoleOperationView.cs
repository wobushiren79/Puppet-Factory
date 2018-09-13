using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleOperationView : BaseMVCView {

    /// <summary>
    /// 向左移动操作
    /// </summary>
    /// <param name="moveAxis"></param>
    public void moveLeft(float moveAxis)
    {
    
    }

    /// <summary>
    /// 向右移动操作
    /// </summary>
    /// <param name="moveAxis"></param>
    public void moveRight(float moveAxis)
    {

    }

    /// <summary>
    /// 向上移动操作
    /// </summary>
    /// <param name="moveAxis"></param>
    public void moveUp(float moveAxis)
    {

    }

    /// <summary>
    /// 向下移动操作
    /// </summary>
    /// <param name="moveAxis"></param>
    public void moveDown(float moveAxis)
    {

    }

    /// <summary>
    /// 跳跃操作
    /// </summary>
    public void jump()
    {

    }

    private void baseMove()
    {
        CreatureMovementCpt movementCpt = getContent().GetComponent<CreatureMovementCpt>();
        if (movementCpt)
        {

        }
    }
}

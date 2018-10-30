using UnityEngine;
using UnityEditor;

public class CreatureMovementCpt : BaseComponent
{
    public Vector3 mMoveDirection;

    private CreatureMovementController mCreatureMovementController;
    private  void Awake()
    {
        mCreatureMovementController = new CreatureMovementController(this);
        mMoveDirection = Vector3.zero;
    }

    private void FixedUpdate()
    {
        if (mMoveDirection != null && mMoveDirection != Vector3.zero)
        {
            mCreatureMovementController.CreatureMove(mMoveDirection);
            mMoveDirection = Vector3.zero;
        }
    }

    /// <summary>
    /// 左移
    /// </summary>
    public void CreatureMoveLeft()
    {
        mMoveDirection.x -= 1f;
    }

    /// <summary>
    /// 右移
    /// </summary>
    public void CreatureMoveRight()
    {
        mMoveDirection.x += 1f;
    }

    /// <summary>
    /// 前移
    /// </summary>
    public void CreatureMoveForward()
    {
        mMoveDirection.z += 1f;
    }

    /// <summary>
    /// 后移
    /// </summary>
    public void CreatureMoveBackward()
    {
        mMoveDirection.z -= 1f;
    }

    /// <summary>
    /// 跳跃
    /// </summary>
    public void CreatureJump()
    {
        mCreatureMovementController.CreatureJump();
    }

}
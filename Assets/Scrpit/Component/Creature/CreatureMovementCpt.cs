using UnityEngine;
using UnityEditor;

public class CreatureMovementCpt : BaseComponent<CreatureMovementModel, CreatureMovementView, CreatureMovementController>
{
    public Vector3 mMoveDirection;

    private new void Awake()
    {
        base.Awake();
        mMoveDirection = Vector3.zero;
    }

    private void FixedUpdate()
    {
        if (mMoveDirection != null && mMoveDirection != Vector3.zero)
        {
            mController.creatureMove(mMoveDirection);
            mMoveDirection = Vector3.zero;
        }
    }

    /// <summary>
    /// 左移
    /// </summary>
    public void creatureMoveLeft()
    {
        mMoveDirection.x -= 1f;
    }

    /// <summary>
    /// 右移
    /// </summary>
    public void creatureMoveRight()
    {
        mMoveDirection.x += 1f;
    }

    /// <summary>
    /// 前移
    /// </summary>
    public void creatureMoveForward()
    {
        mMoveDirection.z += 1f;
    }

    /// <summary>
    /// 后移
    /// </summary>
    public void creatureMoveBackward()
    {
        mMoveDirection.z -= 1f;
    }

    /// <summary>
    /// 跳跃
    /// </summary>
    public void creatureJump()
    {
        mController.creatureJump();
    }

}
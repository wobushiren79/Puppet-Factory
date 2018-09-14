using UnityEngine;
using UnityEditor;

public class CreatureMovementView : BaseMVCView
{
    //运动刚体
    public Rigidbody mCreatureRB;

    public override void initData()
    {
        mCreatureRB = getContent().GetComponent<Rigidbody>();
    }

    /// <summary>
    /// 创建物移动
    /// </summary>
    /// <param name="direction">移动方向</param>
    /// <param name="moveSpeed">移动速度</param>
    /// <param name="rotationRate">转身速率</param>
    public void creatureMove(Vector3 direction, long moveSpeed,float rotationRate)
    {
        if (mCreatureRB == null)
        {
            LogUtil.Log("移动失败：没有该移动物体没有刚体");
            return;
        }
        //LogUtil.Log("开始移动 directionX："+ direction.x+ " directionY：" + direction.y + " directionZ：" + direction.z);
        //开始移动
        mCreatureRB.MovePosition(getContent().transform.position + direction * moveSpeed * Time.deltaTime);

        //转身 正面朝前
        Quaternion creatureRotation = Quaternion.Lerp(getContent().transform.rotation, Quaternion.Euler(
            0f, (direction.x > 0f ? 1f : -1f) * Vector2.Angle(Vector2.up, new Vector2(direction.x,direction.z)) + 180f, 0f
        ), rotationRate);
        getContent().transform.rotation = creatureRotation;
    }

    /// <summary>
    /// 创建物跳跃
    /// </summary>
    /// <param name="jumpEfforts"></param>
    public void creatureJump(long jumpEfforts)
    {
        if (mCreatureRB == null)
        {
            LogUtil.Log("跳跃失败：没有该移动物体没有刚体");
            return;
        }
        //LogUtil.Log("开始跳跃 jumpEfforts：" + jumpEfforts);
        mCreatureRB.AddForce(new Vector3(0, jumpEfforts, 0),ForceMode.Impulse);
    }
}
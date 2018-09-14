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
    /// <param name="direction"></param>
    public void creatureMove(Vector3 direction, long moveSpeed)
    {
        if (mCreatureRB == null)
        {
            LogUtil.Log("移动失败：没有该移动物体没有刚体");
            return;
        }
        //LogUtil.Log("开始移动 directionX："+ direction.x+ " directionY：" + direction.y + " directionZ：" + direction.z);
        mCreatureRB.MovePosition(getContent().transform.position + direction * moveSpeed * Time.deltaTime);
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
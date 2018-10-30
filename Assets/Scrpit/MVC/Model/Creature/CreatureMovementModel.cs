using UnityEngine;
using UnityEditor;

public class CreatureMovementModel : BaseMVCModel
{
    //属性处理biz
    private CreatureAttributeBiz mAttributeBiz;
    //属性查询service
    private CreatureAttributeService mAttributeService;

    /// <summary>
    /// 初始化数据
    /// </summary>
    public override void InitData()
    {
        mAttributeBiz = new CreatureAttributeBiz();
        mAttributeService = new CreatureAttributeService();
    }

    /// <summary>
    /// 获取物体移动速度
    /// </summary>
    /// <returns></returns>
    public long GetCreatureMoveSpeed()
    {
      return mAttributeBiz.getCreatureMoveSpeed(null);
    }

    /// <summary>
    /// 获取物体转身速率
    /// </summary>
    /// <returns></returns>
    public float GetCreatureRotationRate()
    {
        return mAttributeBiz.getCreatureRotationRate(null);
    }

    /// <summary>
    /// 获取物体的跳跃力度
    /// </summary>
    /// <returns></returns>
    public long GetCreatureJumpEfforts()
    {
        return mAttributeBiz.getCreatureJumpEfforts(null);
    }

}
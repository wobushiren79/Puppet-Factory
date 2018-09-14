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
    public override void initData()
    {
        mAttributeBiz = new CreatureAttributeBiz();
        mAttributeService = new CreatureAttributeService();
    }

    /// <summary>
    /// 获取物体移动速度
    /// </summary>
    /// <returns></returns>
    public long getCreatureMoveSpeed()
    {
      return mAttributeBiz.getCreatureMoveSpeed(null);
    }

    /// <summary>
    /// 获取物体的跳跃力度
    /// </summary>
    /// <returns></returns>
    public long getCreatureJumpEfforts()
    {
        return mAttributeBiz.getCreatureJumpEfforts(null);
    }


}
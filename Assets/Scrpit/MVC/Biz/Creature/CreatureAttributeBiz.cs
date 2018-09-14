using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureAttributeBiz
{
    /// <summary>
    /// 根据属性获取物体移动速度
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public long getCreatureMoveSpeed(CreatureBean data)
    {
        long moveSpeed = 5;
        return moveSpeed;
    }

   /// <summary>
   /// 根据属性获取物体跳跃力度
   /// </summary>
   /// <param name="data"></param>
   /// <returns></returns>
    public long getCreatureJumpEfforts(CreatureBean data)
    {
        long jumpEfforts = 5;
        return jumpEfforts;
    }
}

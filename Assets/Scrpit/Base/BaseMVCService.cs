using UnityEngine;
using UnityEditor;

public abstract class BaseMVCService<T>
{
    /// <summary>
    /// 增加数据
    /// </summary>
    /// <param name="data"></param>
    public abstract void add(T data);

    /// <summary>
    /// 删除数据
    /// </summary>
    /// <param name="data"></param>
    public abstract void delete(T data);

    /// <summary>
    /// 更新数据
    /// </summary>
    /// <param name="data"></param>
    public abstract void update(T data);

    /// <summary>
    /// 查询数据
    /// </summary>
    /// <param name="data"></param>
    public abstract void query(T data);
}
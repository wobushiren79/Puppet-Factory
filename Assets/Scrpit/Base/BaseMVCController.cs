using UnityEngine;
using UnityEditor;

public class BaseMVCController<M,V> : BaseMonoBehaviour
{
    //模型
    private M mModel;
    //视图
    private V mView;

    /// <summary>
    /// 设置模型
    /// </summary>
    /// <param name="model"></param>
    public void setModel(M model)
    {
        this.mModel= model;
    }

    /// <summary>
    /// 设置视图
    /// </summary>
    /// <param name="mView"></param>
    public void setView(V view)
    {
        this.mView = view;
    }
}
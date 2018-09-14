using UnityEngine;
using UnityEditor;

public abstract  class BaseMVCController<M,V> : BaseMVC
{
    //模型
    public M mModel;
    //视图
    public V mView;

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
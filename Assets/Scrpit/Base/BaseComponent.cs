using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseComponent<M,V,C> : BaseMonoBehaviour
where M : BaseMVCModel
where V : BaseMVCView
where C : BaseMVCController<M,V>
{
    //控制器
    private M mModel;
    //模型
    private V mView;
    //视图
    private C mController; 

    /// <summary>
    /// 初始化
    /// </summary>
    private void Awake()
    {
        //添加相应模型
        mModel = gameObject.AddComponent<M>();
        //添加相应视图
        mView = gameObject.AddComponent<V>();
        //添加相应控制器
        mController = gameObject.AddComponent<C>();
        //设置Controller模型
        mController.setModel(mModel);
        //设置Controller视图
        mController.setView(mView);
    }
}

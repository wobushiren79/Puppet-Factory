using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseComponent<M, V, C> : BaseMonoBehaviour
where M : BaseMVCModel,new()
where V : BaseMVCView, new()
where C : BaseMVCController<M, V>, new()
{
    //控制器
    public M mModel;
    //模型
    public V mView;
    //视图
    public C mController;

    /// <summary>
    /// 初始化
    /// </summary>
    private void Awake()
    {
        //添加相应模型
        mModel = new M();
        mModel.setContent(this);

        //添加相应视图
        mView = new V();
        mView.setContent(this);

        //添加相应控制器
        mController = new C();
        mController.setContent(this);
        //设置Controller模型
        mController.setModel(mModel);
        //设置Controller视图
        mController.setView(mView);
    }
}

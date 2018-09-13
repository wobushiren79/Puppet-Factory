using UnityEngine;
using UnityEditor;

public class BaseMVC 
{
    //上下文对象
    public BaseMonoBehaviour mContent;

    /// <summary>
    /// 设置上下文对象
    /// </summary>
    /// <param name="content"></param>
    public void setContent(BaseMonoBehaviour content)
    {
        this.mContent = content;
    }

    /// <summary>
    /// 获取上下文对象
    /// </summary>
    /// <returns></returns>
    public BaseMonoBehaviour getContent()
    {
        return mContent;
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg
{
/// <summary>
/// 资源包
/// </summary>
public sealed partial class ResPack : Luban.BeanBase
{
    public ResPack(JSONNode _buf) 
    {
        { if(!_buf["prefabName"].IsString) { throw new SerializationException(); }  PrefabName = _buf["prefabName"]; }
    }

    public static ResPack DeserializeResPack(JSONNode _buf)
    {
        return new ResPack(_buf);
    }

    /// <summary>
    /// prefabName
    /// </summary>
    public readonly string PrefabName;
   
    public const int __ID__ = -1533880647;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "prefabName:" + PrefabName + ","
        + "}";
    }
}

}


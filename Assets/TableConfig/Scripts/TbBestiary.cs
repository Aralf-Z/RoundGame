
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
public partial class TbBestiary
{
    private readonly System.Collections.Generic.Dictionary<int, Bestiary> _dataMap;
    private readonly System.Collections.Generic.List<Bestiary> _dataList;
    
    public TbBestiary(JSONNode _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Bestiary>();
        _dataList = new System.Collections.Generic.List<Bestiary>();
        
        foreach(JSONNode _ele in _buf.Children)
        {
            Bestiary _v;
            { if(!_ele.IsObject) { throw new SerializationException(); }  _v = Bestiary.DeserializeBestiary(_ele);  }
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Bestiary> DataMap => _dataMap;
    public System.Collections.Generic.List<Bestiary> DataList => _dataList;

    public Bestiary GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Bestiary Get(int key) => _dataMap[key];
    public Bestiary this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}


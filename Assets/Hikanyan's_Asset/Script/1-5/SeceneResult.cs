using UnityEngine;
using UnityEngine.UI;
public class SeceneResult : DeliveryBase<SeceneResult.Arg>
{
    [SerializeField] Text _text;
    public class Arg
    {
        public int sceneRed;
        public int sceneBlue;
        public int sceneyellow;
    }
    public override void Initialize(SeceneResult.Arg arg)
    {
        _text.text = ($"赤：{arg.sceneRed}\n青：{arg.sceneBlue}\n黄：{arg.sceneyellow}");
        Debug.Log($"赤：{arg.sceneRed}\n青：{arg.sceneBlue}\n黄：{arg.sceneyellow}");
    }
}
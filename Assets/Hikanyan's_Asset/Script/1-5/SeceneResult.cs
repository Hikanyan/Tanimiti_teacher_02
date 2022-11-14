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
        _text.text = ($"�ԁF{arg.sceneRed}\n�F{arg.sceneBlue}\n���F{arg.sceneyellow}");
        Debug.Log($"�ԁF{arg.sceneRed}\n�F{arg.sceneBlue}\n���F{arg.sceneyellow}");
    }
}
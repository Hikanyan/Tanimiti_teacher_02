using UnityEngine;

public class Scene02 : DeliveryBase<Scene02.Arg>
{
    public class Arg
    {
        public string text;
    }
    public override void Initialize(Arg arg)
    {
        Debug.Log("Scene02�����[�h����A���̃V�[��������������" + arg.text);
    }
}
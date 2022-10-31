using UnityEngine;

public class Scene03 : DeliveryBase<Scene03.Arg>
{
    public class Arg
    {
        public string text;
    }
    public override void Initialize(Arg arg)
    {
        Debug.Log("Scene03がロードされ、他のシーンからもらったよ" + arg.text);
    }
}
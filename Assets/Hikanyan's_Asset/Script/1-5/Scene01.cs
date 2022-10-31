using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01 : DeliveryBase<Scene01 .Arg>
{
    public class Arg
    {
        public string text;
    }
    public override void Initialize(Arg arg)
    {
        Debug.Log("Scene01がロードされ、他のシーンからもらったよ" + arg.text);
    }
}

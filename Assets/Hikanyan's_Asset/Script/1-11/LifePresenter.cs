using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
///Presenter‚ÍŽQÆ‚ðŽ‚Â‚æ‚¤‚É‚·‚é
public class LifePresenter : MonoBehaviour
{
    [SerializeField] PlayerData _playerData;
    [SerializeField] LifeView _lifeView;

    private void Start()
    {
        //Subscribe‚ÅLife‚Ì’l‚ð‚Æ‚é‚Æ•Ï‚í‚Á‚½‚Æ‚«‚ÉLifeView‚ð•ÏX‚·‚é
        _playerData.Life.Subscribe(life =>
        {
            _lifeView.SetLife(life);
        }).AddTo(this);
    }
}

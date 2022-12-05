using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
using TMPro;
public class UniRxReactivepropertyClick : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _countText;
    [SerializeField] int _addValue;
    [SerializeField] List<Button> _buttons;
    private ReactiveProperty<int> _count = new ReactiveProperty<int>();

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(AddCount);
    }
    private void Start()
    {
        _count
            .Subscribe(count =>
            {
                _countText.text = count.ToString();
            }).AddTo(gameObject);
    }

    public void AddCount()
    {
        _count.Value += _addValue;
    }
}

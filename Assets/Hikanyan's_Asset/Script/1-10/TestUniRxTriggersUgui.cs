using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TestUniRxTriggersUgui : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI uguiText;
    void Start()
    {
        uguiText.OnPointerClickAsObservable()
        .Subscribe(_ => uguiText.text = "ƒNƒŠƒbƒN‚³‚ê‚½‚æ");
    }
}

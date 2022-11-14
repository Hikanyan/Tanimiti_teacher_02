using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    [SerializeField] Text countUpText;
    [SerializeField] Button closeButton;
    [SerializeField] Button openButton;

    private void Start()
    {
        openButton.interactable = true;
    }

    public void Open()
    {
        openButton.interactable = false;
        closeButton.interactable = false;
        this.transform.DOScale(1, 0.3f).SetEase(Ease.InOutBounce).OnComplete(CountUp);
    }

    private void CountUp()
    {
        DOVirtual.Float(0f, 100f, 3f, value =>
        {
            countUpText.text = "Count : " + (int)value;
        }).OnComplete(() => {
            closeButton.interactable = true;
        });
    }

    public void Close()
    {
        this.transform.DOScale(0, 0.3f).SetEase(Ease.InQuad).OnComplete(() => {
            openButton.interactable = true;
        });
    }
}
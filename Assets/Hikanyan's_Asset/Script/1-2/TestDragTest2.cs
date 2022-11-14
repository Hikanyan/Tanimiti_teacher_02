using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestDragTest2 : MonoBehaviour, IDragHandler, IDropHandler,IPointerEnterHandler,IPointerExitHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }
    public void OnDrop(PointerEventData eventData)
    {
        var results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);
        foreach (var hit in results)
        {
            if (hit.gameObject.name == "Destroy")
            {
                transform.position = hit.gameObject.transform.position;
                Debug.Log("‚Å‚·‚Æ‚ë‚¢");
                Destroy(this.gameObject);
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }
}


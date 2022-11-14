using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestDragTest1 : MonoBehaviour, IDragHandler, IDropHandler
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
}

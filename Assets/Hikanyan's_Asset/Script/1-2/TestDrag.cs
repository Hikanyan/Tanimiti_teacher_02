using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TestDrag : MonoBehaviour, IDragHandler, IDropHandler
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
            if (hit.gameObject.name == "Set")
            {
                transform.position = hit.gameObject.transform.position;
                Debug.Log("ƒZƒbƒg‚³‚ê‚½");
            }
        }
    }
}

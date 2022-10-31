using UnityEngine;
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                var previous = FindObjectOfType(typeof(T));
                if (previous != null)
                {
                    _instance = (T)previous;
                }
                else
                {
                    var go = new GameObject(typeof(T).Name);
                    _instance = go.AddComponent<T>();
                }
            }
            return _instance;
        }
    }

    public bool dontDestroy = true;
    private void Awake()
    {
        if (dontDestroy)
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
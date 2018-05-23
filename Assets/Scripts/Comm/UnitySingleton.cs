/*
 * @Author: lgn 
 * @Date: 2018-05-23 20:15:29 
 * @Last Modified by:   lgn 
 * @Last Modified time: 2018-05-23 20:15:29 
 */

using UnityEngine;

public abstract class UnitySingleton<T> : MonoBehaviour where T : Component
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType(typeof(T)) as T;
                if (_instance == null)
                {
                    var obj = new GameObject("[--- " + typeof(T).Name + " ---]");
                    _instance = (T)obj.AddComponent(typeof(T));
                }
            }
            return _instance;
        }
    }

    public virtual void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (_instance == null)
        {
            _instance = this as T;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

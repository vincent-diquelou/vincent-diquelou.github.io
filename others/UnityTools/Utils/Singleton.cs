/*
 * Simple Singleton created by Vincent Diquélou (vincent.diquelou.pro@gmail.com)
 * Be mindfull this may call FindObjectOfType witch is a performence intensive function (At first call and when called with a class that doesnt exist in the current context)
*/
using UnityEngine;

namespace Utils
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected static T _instance;

        protected virtual void Awake()
        {
            if (_instance == null)
                _instance = this as T;
            else if (_instance != this)
            {
                Destroy(gameObject);
            }
        }

        public static T Instance
        {
            get
            {
                if (_instance != null) return _instance;
                if (_instance == null) _instance = FindObjectOfType<T>(true);
                if (_instance == null) Debug.LogError($"Singleton : cant find component of type : {typeof(T).ToString()} in the current scene.");
                return _instance;
            }
        }

        private void OnDestroy()
        {
            if (_instance == this) _instance = null;
        }
    }
}

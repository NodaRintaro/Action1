using UnityEngine;

namespace Singleton
{
    /// <summary>
    /// シングルトン基底クラス(MonoBehaviour継承)
    /// </summary>
    public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
    {
        static T instance;
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = (T)FindObjectOfType(typeof(T));
                    if ((instance == null))
                    {
                        Debug.LogWarning(typeof(T) + "is nothing");
                    }
                }
                return instance;
            }
        }
    }
}
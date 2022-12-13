using UnityEngine;
using UnityEngine.SceneManagement;
/*using static UnityEditor.Progress;*/

public class DontDestroyOnLoadScene : MonoBehaviour
{
    public GameObject[] objects;

    public static DontDestroyOnLoadScene instance;
    private void Awake()
    {
        if(instance != null)
        {
            foreach(var item in objects)
            {
                Destroy(item);
            }
            Destroy(gameObject);
            return;
        }

        instance = this;
        foreach (var item in objects)
        {
            DontDestroyOnLoad(item);
        }
    }
    public void RemoveFromDontDestroyOnload()
    {
        foreach (var item in objects)
        {
            SceneManager.MoveGameObjectToScene(item, SceneManager.GetActiveScene());
        }
    }
}

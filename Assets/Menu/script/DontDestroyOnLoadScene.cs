using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoadScene : MonoBehaviour
{
    public GameObject[] objects;

    public static DontDestroyOnLoadScene instance;
    private void Awake()
    {
        if(instance != null)
        {
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

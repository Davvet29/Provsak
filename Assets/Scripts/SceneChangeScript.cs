using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    public void ChangeScene(string scene)
    {
        Debug.Log(scene);
        SceneManager.LoadScene(scene);
    }
}

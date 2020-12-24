using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}

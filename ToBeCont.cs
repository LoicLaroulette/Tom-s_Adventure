using UnityEngine;
using UnityEngine.SceneManagement;

public class ToBeCont : MonoBehaviour
{    void OnEnable()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCmplete : MonoBehaviour
{
   
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

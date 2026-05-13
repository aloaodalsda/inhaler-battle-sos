using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    public void Play()
    {
      SceneManager.LoadScene("level 1");
    }
    public void Exit()
    {
       Application.Quit();
       Debug.Log("sos");
    }

}

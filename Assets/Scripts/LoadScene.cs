using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField]
    private int m_SceneIndex = 1;

public void LoadTargetScene()
{
    SceneManager.LoadScene(m_SceneIndex);
}

}

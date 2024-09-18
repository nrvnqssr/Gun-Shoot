using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    #region Singleton
    public static SceneLoader Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    [SerializeField] private bool _isCursorLocked = true;
    [SerializeField] private string _sceneName;

    private void Start()
    {
        if ( (_isCursorLocked))
            Cursor.lockState = CursorLockMode.Locked;
        else 
            Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Restart();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Exit();
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}

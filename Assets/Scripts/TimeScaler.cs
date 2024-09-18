using Unity.VisualScripting;
using UnityEngine;

public class TimeScaler : MonoBehaviour
{
    [SerializeField] private float _reachTimeScale = 0.33f;

    private void Start()
    {
        Time.timeScale = 1.0f;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown((int)MouseButton.Right))
            Time.timeScale = _reachTimeScale;

        if (Input.GetMouseButtonUp((int)MouseButton.Right))
            Time.timeScale = 1.0f;
    }
}

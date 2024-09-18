using UnityEngine;

public class Victory : MonoBehaviour
{
    [SerializeField] private GameObject VictoryUI;

    private void Start()
    {
        VictoryUI.SetActive(false);
    }

    private void OnEnable()
    {
        Objectives.OnObjectivesComplete += EnableVictoryUI;
    }

    private void OnDisable()
    {
        Objectives.OnObjectivesComplete -= EnableVictoryUI;
    }

    private void EnableVictoryUI()
    {
        //������ ������ ��������� ��� ������.
        Cursor.lockState = CursorLockMode.Confined;
        
        VictoryUI.SetActive(true);
    }
}

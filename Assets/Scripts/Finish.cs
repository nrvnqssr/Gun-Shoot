using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //���������, �������� �� ������, � ������� ��������� ��������, ������� (����������).
        if (other.tag == "Player")
            Objectives.Instance.FinishIsReachedSwitch();
    }

    private void OnTriggerExit(Collider other)
    {
        //���������, �������� �� ������, � ������� ��������� ��������, ������� (����������).
        if (other.tag == "Player")
            Objectives.Instance.FinishIsReachedSwitch();
    }
}
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Проверяет, является ли объект, с которым произошла коллизия, игроком (пистолетом).
        if (other.tag == "Player")
            Objectives.Instance.FinishIsReachedSwitch();
    }

    private void OnTriggerExit(Collider other)
    {
        //Проверяет, является ли объект, с которым произошла коллизия, игроком (пистолетом).
        if (other.tag == "Player")
            Objectives.Instance.FinishIsReachedSwitch();
    }
}
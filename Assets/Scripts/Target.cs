using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private GameObject _deathFX;

    private void OnCollisionEnter(Collision collision)
    {
        //Проверка, является ли объект, с которым произошла коллизия, пулей.
        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(_deathFX, transform.position, Quaternion.identity);
            
            if (Objectives.Instance != null)
                Objectives.Instance.UpdateTargetsCount();

            Destroy(gameObject);
        }
    }
}

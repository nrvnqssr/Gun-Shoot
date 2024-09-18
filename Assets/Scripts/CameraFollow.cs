using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject _gun;
    [SerializeField] private Vector3 _offset;

    private void Update()
    {
        //Перемещает камеру в позицию оружия с некоторым смещением.
        Camera.main.gameObject.transform.position = _gun.transform.position + _offset;
    }
}

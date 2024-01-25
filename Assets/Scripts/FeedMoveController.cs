using System.Security.Cryptography;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FeedMoveController : MonoBehaviour
{
    [SerializeField] float _power = 5f;
    [SerializeField] float _deleteTime = 10f;
    Rigidbody _rigidbody;
    Ray _ray;

    private void Awake()
    {
        //�@Rigidbody���擾�����x��0�ɏ�����
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {

        //�@�J��������N���b�N�����ʒu�Ƀ��C���΂�
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //�@�e�����݂��Ă���΃��C�̕����ɗ͂�������
        _rigidbody.AddForce(_ray.direction * _power, ForceMode.Impulse);

        //�@�e�𔭎˂��Ă���w�肵�����Ԃ��o�߂����玩���ō폜
        Destroy(this.gameObject, _deleteTime);
    }

    private void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        // Enemy�^�O�������G�ɏՓ˂����玩�g�ƓG���폜
        if (collision.gameObject.tag == ("Carp"))
        {
            this.gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedPitcher : MonoBehaviour
{
    /// <summary>�e�̃v���n�u</summary>
    [SerializeField] Camera _camera;
    /// <summary>�e�̃v���n�u</summary>
    [SerializeField] GameObject _bullet;
    /// <summary>�����Y����̃I�t�Z�b�g�l</summary>
    [SerializeField] float _offset;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            //�@�J�����̃����Y�̒��S�����߂�
            var centerOfLens = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.nearClipPlane + _offset));
            //�@�J�����̃����Y�̒��S����e���΂�
            var bulletObj = Instantiate(_bullet, centerOfLens, Quaternion.identity) as GameObject;
        }
    }
}

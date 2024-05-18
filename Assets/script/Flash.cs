using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Flash : MonoBehaviour
{
    // �_�ł�����Ώ�
    [SerializeField] private TextMeshProUGUI _target;
    // �_�Ŏ���[s]
    [SerializeField] private float _cycle = 1;

    private double _time;

    private void Update()
    {
        // �����������o�߂�����
        _time += Time.deltaTime;

        // ����cycle�ŌJ��Ԃ��l�̎擾
        // 0�`cycle�͈̔͂̒l��������
        var repeatValue = Mathf.Repeat((float)_time, _cycle);

        // ��������time�ɂ����閾�ŏ�Ԃ𔽉f
        _target.enabled = repeatValue >= _cycle * 0.5f;
    }
}

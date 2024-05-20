using TMPro;
using Unity.VisualScripting;
using UnityEngine;

// ScriptableObject���p�����AUnity�G�f�B�^�̃��j���[���琶���\�ɂ��鑮���ݒ�
[CreateAssetMenu(fileName = "GameSharedData", menuName = "ScriptableObjects/GameSharedData")]
public class GameSharedData : ScriptableObject
{
    // �v���C���[�̃X�R�A�����J�ϐ��Ƃ��ĕێ�
    public int playerScore; // �v���C���[�̃X�R�A��\�������^�̌��J�t�B�[���h
    public int stageSelect;
    public int myFighter = 4;
    public int pow = 1;
    public int Speed = 2;
    public string gameover = "GameOver";
    public bool stageClear;
    public bool isCheck;
    public float span = 0.3f;
    public int GameOverScore;
    public string GameOverName;
    public string game;

}
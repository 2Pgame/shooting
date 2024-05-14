using UnityEngine;

// ScriptableObject���p�����AUnity�G�f�B�^�̃��j���[���琶���\�ɂ��鑮���ݒ�
[CreateAssetMenu(fileName = "GameSharedData", menuName = "ScriptableObjects/GameSharedData")]
public class GameSharedData : ScriptableObject
{
    // �v���C���[�̃X�R�A�����J�ϐ��Ƃ��ĕێ�
    public int playerScore; // �v���C���[�̃X�R�A��\�������^�̌��J�t�B�[���h
    public int stageSelect;
    public int pow = 1;
    public unityStage unitystage;
    public enum unityStage
    {
        Landscape,
        Beach,
        Mountain,
        Space
    }
}
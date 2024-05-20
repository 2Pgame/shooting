using UnityEngine;

public class Ranking : MonoBehaviour
{
    public RankingManager rankingManager;
    public RankingUI rankingUI;
    [SerializeField]GameSharedData gameSharedData;

    void Start()
    {
        Debug.Log(gameSharedData.playerScore);
        Debug.Log(gameSharedData.GameOverName);
        // ���̓f�[�^������
        rankingManager.AddRankingEntry(gameSharedData.GameOverName,gameSharedData.playerScore,gameSharedData.game);


        // UI���X�V���ĕ\��
        rankingUI.DisplayRanking();
    }
}
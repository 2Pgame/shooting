using UnityEngine;

public class TestRanking : MonoBehaviour
{
    public RankingManager rankingManager;
    public RankingUI rankingUI;

    void Start()
    {
        // �T���v���f�[�^��ǉ�
        rankingManager.AddRankingEntry("Player1", 100);
        rankingManager.AddRankingEntry("Player2", 200);
        rankingManager.AddRankingEntry("Player3", 150);

        // UI���X�V���ĕ\��
        rankingUI.DisplayRanking();
    }
}
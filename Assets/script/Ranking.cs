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
        // 入力データを入れる
        rankingManager.AddRankingEntry(gameSharedData.GameOverName,gameSharedData.playerScore,gameSharedData.game);


        // UIを更新して表示
        rankingUI.DisplayRanking();
    }
}
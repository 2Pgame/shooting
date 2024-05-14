using UnityEngine;

// ScriptableObjectを継承し、Unityエディタのメニューから生成可能にする属性設定
[CreateAssetMenu(fileName = "GameSharedData", menuName = "ScriptableObjects/GameSharedData")]
public class GameSharedData : ScriptableObject
{
    // プレイヤーのスコアを公開変数として保持
    public int playerScore; // プレイヤーのスコアを表す整数型の公開フィールド
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
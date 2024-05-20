using TMPro;
using Unity.VisualScripting;
using UnityEngine;

// ScriptableObjectを継承し、Unityエディタのメニューから生成可能にする属性設定
[CreateAssetMenu(fileName = "GameSharedData", menuName = "ScriptableObjects/GameSharedData")]
public class GameSharedData : ScriptableObject
{
    // プレイヤーのスコアを公開変数として保持
    public int playerScore; // プレイヤーのスコアを表す整数型の公開フィールド
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
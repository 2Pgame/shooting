using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputFieldTest : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField]GameSharedData gameSharedData;

    private void Start()
    {
        SubscribeToInputFieldEvents();
    }

    private void SubscribeToInputFieldEvents()
    {
        if (inputField != null)
        {
            inputField.onEndEdit.AddListener(OnEnterInputField);
        }
        else
        {
            Debug.LogError("InputFieldが割り当てられていません。");
        }
    }

    private void OnEnterInputField(string inputMsg)
    {
        gameSharedData.GameOverName = inputMsg;
        SceneManager.LoadScene("Stage1", LoadSceneMode.Single);
        SceneManager.LoadScene("MainUI", LoadSceneMode.Additive);
    }
}
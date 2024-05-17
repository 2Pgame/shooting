using TMPro;
using UnityEngine;

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
            Debug.LogError("InputField�����蓖�Ă��Ă��܂���B");
        }
    }

    private void OnEnterInputField(string inputMsg)
    {
        gameSharedData.GameOverName = inputMsg;
        Debug.Log("InputField�̒l: " + gameSharedData.GameOverName);
    }
}
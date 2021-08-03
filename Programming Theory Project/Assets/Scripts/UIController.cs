using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
	[SerializeField] private InputField _inputField;

	[SerializeField] private Text _nameText;

	public void Start()
	{
		DataManager.Instance.LoadData();
		SetName();

		//Adds a listener that invokes the "LockInput" method when the player finishes editing the main input field.
		//Passes the main input field into the method when "LockInput" is invoked
		_inputField.onEndEdit.AddListener(delegate { LockInput(_inputField); });
	}

	private void LockInput(InputField input)
	{
		if (input.text.Length > 0)
		{
			DataManager.Instance.Name = input.text;
			DataManager.Instance.SaveData();
			SetName();
		}
		else if (input.text.Length == 0)
		{
			Debug.Log("Input Empty");
		}
	}

	private void SetName()
	{
		_nameText.text = DataManager.Instance.Name;
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CustomModels : MonoBehaviour {
	[Space(5f)]
	[Header("Dependencies")]
	public CustomContentMenuManager customContentMenu;

	[Space(5f)]
	[Header("Variables")]
	public List<CustomModel> customModels = new List<CustomModel>();
	public Dictionary<Doru_Type, CustomModel> customModelDictionary = new Dictionary<Doru_Type, CustomModel>();

	IEnumerator Start () {
		DirectoryInfo dir = new DirectoryInfo(Path.Combine(Application.streamingAssetsPath, "models"));
		FileInfo[] info = dir.GetFiles("*.*");
		foreach (FileInfo f in info) {
			AssetBundleCreateRequest  bundleRequest = AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, "models/" + f.Name));
			yield return bundleRequest;

			AssetBundle tempBundle = bundleRequest.assetBundle;
			//AssetBundle tempBundle = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "models/" + f.Name));
			if (tempBundle) {
				//Debug.Log(tempBundle);
				Object tempObject = tempBundle.LoadAsset("ModelContainer");
				CustomModelInfo cm = (tempObject as GameObject).GetComponent<CustomModelInfo>();
				if (cm != null) {
					customModels.Add(cm.customModelInformation);
					if (!customContentMenu) customContentMenu = FindObjectOfType(typeof(CustomContentMenuManager)) as CustomContentMenuManager;
					if (customContentMenu) customContentMenu.AddCustomModel(cm.customModelInformation);
				}
			}
		}
	}

	public void MainMenuLoaded () {
		if (!customContentMenu) customContentMenu = FindObjectOfType(typeof(CustomContentMenuManager)) as CustomContentMenuManager;
		foreach (CustomModel cm in customModels) {
			customContentMenu.AddCustomModel(cm);
			//customContentMenu.UpdateListing(customContentMenu.dropdown.GetCurrentDoruType());
		}
	}

	public void AddToDictionary (Doru_Type type, CustomModel cm) {
		customModelDictionary[type] = cm;
		//Debug.Log("Added to Dictionary [Key]: " + type + " [Value]: " + customModelDictionary[type].name);
	}
	public void RemoveFromDictionary (Doru_Type type) {
		customModelDictionary.Remove(type);
		//Debug.Log("Removed from Dictionary [Key]: " + type);
	}
}

[System.Serializable]
public struct CustomModel {
	public GameObject modelPrefab;
	public string name;
	public Sprite image;
	[TextArea]
	public string description;
}
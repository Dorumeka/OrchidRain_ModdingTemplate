using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GibsDictionary", menuName = "Game Stats/Gibs Dictionary")]
public class GibsDictionary : ScriptableObject {
	[SerializeField]
	public Gib[] gibs;
	[SerializeField]
	public GibSet[] gibSets;

	public GameObject GetGib (GibType g) {
		for (int i = 0; i < gibs.Length; i++) {
			if (gibs[i].type == g) return gibs[i].gibPrefab;
		}
		return null;
	}

	public GibType[] GetGibSet (GibSetType g) {
		for (int i = 0; i < gibs.Length; i++) {
			if (gibSets[i].gibSetType == g) return gibSets[i].gibTypes;
		}
		return null;
	}
}

[System.Serializable]
public struct Gib {
	public GibType type;
	public GameObject gibPrefab;
}

[System.Serializable]
public struct GibSet  {
	public GibSetType gibSetType;
	public GibType[] gibTypes;
}
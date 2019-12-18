using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(fileName = "NpcAudioClips", menuName = "Game Stats/NPC Audio Clips")]
public class NpcAudioClips : ScriptableObject {
	[Tooltip("If false, missing lines will not play. If true, vanilla voice lines will be used when there's a missing voice line")]
	public bool replaceMissingLinesWithVanilla;
	[SerializeField]
	public NpcVoiceClip[] genericVoiceClips;
	[SerializeField]
	public NpcVoiceClip[] sensualVoiceClips;
	[SerializeField]
	public NpcVoiceClip[] shyVoiceClips;

	public AudioClip[] GetVoiceClips (DoruPersonality p, VoiceClip type) {
		//Debug.Log("Personality: " + p + "| Voice line: " + type);
		NpcVoiceClip[] voiceClips = genericVoiceClips;
		switch (p) {
			case DoruPersonality.Generic:
				voiceClips = genericVoiceClips;
			break;
			case DoruPersonality.Sensual:
				/*if (sensualVoiceClips.Length > 0) voiceClips = sensualVoiceClips;
				else */voiceClips = genericVoiceClips;
			break;
			case DoruPersonality.Shy:
				/*if (shyVoiceClips.Length > 0) voiceClips = shyVoiceClips;
				else */voiceClips = genericVoiceClips;
			break;
		}
		//Debug.Log("voiceClips: " + voiceClips);

		for (int i = 0; i < voiceClips.Length; i++) {
			if (voiceClips[i].type == type) {
				//Debug.Log("Success");
				if (voiceClips[i].clips.Length > 0) return voiceClips[i].clips;
				else return genericVoiceClips[i].clips;
			}
		}
		return null;
	}
}

[System.Serializable]
public struct NpcVoiceClip {
	public VoiceClip type;
	public AudioClip[] clips;
}
using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Music Data", menuName = "Music Data", order = 1)]
public class MusicScriptableObject : ScriptableObject {
    public int bpm;
	public float[] bassBeats;
	public float[] vocalBeats;
    public float[] melodyBeats;
}

using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Traffic Data", menuName = "Traffic Intersections", order = 1)]
public class IntersectionScriptableObject : ScriptableObject {
	/*public struct Intersection
	{
		Vector3[] intersectionPos;
		bool northOpen, southOpen, eastOpen, westOpen;
	}

	public Intersection[] intersections;*/

	public Vector3[] intersectionPos;

	// x=north, y=east, z=south, w=west
	// 0=closed, 1=open
	public Vector4[] openPathways;
}

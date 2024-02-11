using MessagePack;
using System;
using System.Collections.Generic;

[MessagePackObject, Serializable]
public struct PlayerData
{
	[Key(0)] public UnityEngine.Vector3 position;
	[Key(1)] public float sanity;
}

[MessagePackObject, Serializable]
public struct DemonData
{
	[Key(0)] public UnityEngine.Vector3 position;
	[Key(1)] public int stateName;  //this gets converted back into an enum on load
	[Key(2)] public UnityEngine.Vector3 lastDetectedPlayerPosition;
}

[MessagePackObject, Serializable]
public struct RoomSaveData
{
	[Key(0)] public bool[] componentsEnabled;
}

[MessagePackObject, Serializable]
public struct HouseLightsData
{
	[Key(0)] public bool[] lightsEnabled;
}
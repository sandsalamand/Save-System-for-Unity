using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ToolBox.Serialization;

public class SaveManager
{
	private const string saveFileName = "Save";

	public static event Action OnSavingGame;
	public static event Action OnLoadedGame;

	public static void SaveGame()
	{
		OnSavingGame?.Invoke();
		DataSerializer.SaveFile(saveFileName);
	}

	public static void LoadGame()
	{
		DataSerializer.LoadFile(saveFileName);
		OnLoadedGame?.Invoke();
	}
}

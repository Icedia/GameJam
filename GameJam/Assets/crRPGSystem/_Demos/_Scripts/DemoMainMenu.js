var InGameMenu				: GameObject;var	MainMenuImg				: Texture;					//The image to use for the button to start the menus upprivate var curAction 		: int = 0;private var WindowArea		: Rect = Rect(50,50,400,200);function OnGUI () {	if (GUI.Button(Rect(2, Screen.height - 133, 64, 128), MainMenuImg, "Label"))		gameObject.SendMessage("TraverseMenu");	if (curAction == 0)	{		return;	}	switch (curAction)	{		case 1: HighScores(); break;		case 2: LeaderBoards(); break;		case 3: Settings(); break;		case 4: Credits(); break;	}		if (GUI.Button(Rect(WindowArea.x+WindowArea.width-25,WindowArea.y,25,25),"X"))	{		curAction = 0;		gameObject.SendMessage("ActivateMenu", true, SendMessageOptions.DontRequireReceiver);	}	}function OnStart(){	Debug.Log("Call Application.LoadLevel('scene2')");	Debug.Log("Thus this scene is no longer active");	Debug.Log("And the ingame menu is now active...");		if (InGameMenu)	{		Instantiate(InGameMenu);		Destroy(gameObject);	}}function OnAction1(){	curAction = 1;}function OnAction2(){	curAction = 2;}function OnAction3(){	curAction = 3;}function OnAction4(){	curAction = 4;}function HighScores(){	var w = WindowArea;	GUI.Box(w, "High Scores");	w.y += 50;	GUILayout.BeginArea(w);		GUILayout.BeginVertical();		GUILayout.Label("Instead of showing this,");		GUILayout.Label("You would call your actual High Scores system");		GUILayout.EndVertical();	GUILayout.EndArea();	}function LeaderBoards(){	var w = WindowArea;	GUI.Box(w, "LeaderBoards");	w.y += 50;	GUILayout.BeginArea(w);		GUILayout.BeginVertical();		GUILayout.Label("Instead of showing this,");		GUILayout.Label("You would call your actual leaderboards system");		GUILayout.EndVertical();	GUILayout.EndArea();	}function Settings(){	var w = WindowArea;	GUI.Box(w, "Settings and Config");	w.y += 50;	GUILayout.BeginArea(w);		GUILayout.BeginVertical();		GUILayout.Label("Instead of showing this,");		GUILayout.Label("You would call your own settings system");		GUILayout.EndVertical();	GUILayout.EndArea();	}function Credits(){	var w = WindowArea;	GUI.Box(w, "Credits");	w.y += 50;	GUILayout.BeginArea(w);		GUILayout.BeginVertical();		GUILayout.Label("Instead of showing this,");		GUILayout.Label("You would display your game's credits");		GUILayout.EndVertical();	GUILayout.EndArea();	}
using UnityEngine;
using System.Collections;

public class texto : MonoBehaviour {

	public int puntos=0;

	public string textoDebug="";

	private float hSliderValue = 0.5f;
	private Vector2 scrollPosition;

	public bool hayDebug=false;
	private int contador=0;

	public void depurar(string txt) {
		contador++;
		if (contador==30) {
			contador=0;
			textoDebug="";
		}
		textoDebug=txt+"\n"+textoDebug;

	}

	void OnGUI() {
		GUI.Box(new Rect(0, 0, Screen.width, 20), "DEMO ASTEROIDS 3D - Jose Martinez - DESTRUYE ASTEROIDES");
		GUI.Box(new Rect(0, 20, Screen.width, 30), "cursores: mover, i/o: giro, shift/space: acelera/frena, control: dispara");

		GUI.Box(new Rect(0, Screen.height-30, 200, Screen.height), "Asteroides alcanzados: "+puntos);

		GUI.Box(new Rect(0, Screen.height-70, 200, 40), "Volumen de laudio");
		hSliderValue = GUI.HorizontalSlider (new Rect (20, Screen.height-50, 160, 30), hSliderValue, 0.0f, 1.0f);

		//Debug.Log (hSliderValue);
		this.audio.volume=hSliderValue;

		int xx = Screen.width-200;
		int yy = Screen.height - 400;

		hayDebug = GUI.Toggle(new Rect(Screen.width-150, 0, 150, 30), hayDebug, "Mostrar DEBUG");

		if (hayDebug==true) {
		GUILayout.BeginArea(new Rect(xx,yy,200, 400));
			
			scrollPosition = GUILayout.BeginScrollView(
		    scrollPosition, GUILayout.Width(200), GUILayout.Height(400));

		GUILayout.Label(textoDebug);
		GUILayout.EndScrollView();
		GUILayout.EndArea();
		}

		//GUI.Box(new Rect(Screen.width-200, Screen.height-300, 200, Screen.height), textoDebug);
		//GUI.Box(new Rect(0, 0, 100, 10000), textoDebug);
		//contador++;
		//textoDebug=textoDebug + contador + ": " + "aaaa\n";


	}
}

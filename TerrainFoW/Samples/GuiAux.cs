using UnityEngine;
using System.Collections;

public class GuiAux : MonoBehaviour
{	
	public Cor cor;
	
	void OnMouseOver ()
	{
		Test.OverGUI = true;
	}
	
	void OnMouseExit ()
	{
		Test.OverGUI = false;
	}
	
	void OnMouseDown ()
	{
		Test.CurrentColor = cor;
	}
}

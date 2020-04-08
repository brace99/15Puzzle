using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour
{ 
	public void YouWinner () {
		
	Debug.Log("You Won The Game! CONGRATULATIONS!!! " );
		Application.LoadLevel(0);
		
		
		}

	public Tile right;
	public Tile left;
	public Tile top;
	public Tile bottom;
	public int number;
	
	void OnMouseDown ()
	{
		
		bool isMoved = Move ();
		
		if (isMoved){
			if (GameObject.Find("A1").GetComponent<Tile>().number==1 && 
				GameObject.Find("A2").GetComponent<Tile>().number==2 && 
				GameObject.Find("A3").GetComponent<Tile>().number==3 && 
				GameObject.Find("A4").GetComponent<Tile>().number==4 && 
				GameObject.Find("B1").GetComponent<Tile>().number==5 && 
				GameObject.Find("B2").GetComponent<Tile>().number==6 && 
				GameObject.Find("B3").GetComponent<Tile>().number==7 && 
				GameObject.Find("B4").GetComponent<Tile>().number==8 && 
				GameObject.Find("C1").GetComponent<Tile>().number==9 && 
				GameObject.Find("C2").GetComponent<Tile>().number==10 && 
				GameObject.Find("C3").GetComponent<Tile>().number==11 && 
				GameObject.Find("C4").GetComponent<Tile>().number==12 && 
				GameObject.Find("D1").GetComponent<Tile>().number==13 && 
				GameObject.Find("D2").GetComponent<Tile>().number==14 && 
				GameObject.Find("D3").GetComponent<Tile>().number==15 && 
				GameObject.Find("D4").GetComponent<Tile>().number==0 )
					YouWinner();
		
			Debug.Log ("Tile " + number + " has moved.");
		}
			else 
			{
			Debug.Log ("Tile " + number + " can not move!");
		}
	}
	
	private bool Move ()
	{
	
		if (left != null && left.number == 0) {
			Swap (left);
			return true;
		} else if (right != null && right.number == 0) {
			Swap (right);
			return true;
		} else if (top != null && top.number == 0) {
			Swap (top);
			return true;
		} else if (bottom != null && bottom.number == 0) {
			Swap (bottom);
			return true;
		} else {
			return false;
		}
	}
	

	public void Swap (Tile t)
	{
	
		int tempNumber = t.number;
		Material tempMaterial = t.GetComponent<Renderer>().material;
		t.number = this.number;
		t.GetComponent<Renderer>().material = this.GetComponent<Renderer>().material;
		this.number = tempNumber;
		this.GetComponent<Renderer>().material = tempMaterial;
	}

}

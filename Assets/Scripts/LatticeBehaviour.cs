using UnityEngine;
using System.Collections;

public abstract class LatticeBehaviour : TimedBehaviour {

	private int x_pos;
	private int y_pos;
	private Map map;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void TickUpdate()
    {
        if(shouldDestroyed())
        {
            //destroy routine
        }
    }

    public abstract bool isInBody(int xpos, int ypos);

    protected abstract bool shouldDestroyed();



	public int getXPos() {
		return x_pos;
	}

	public int getYPos() {
		return y_pos;
	}

	private void updatePos() {
		transform.position = new Vector3 (x_pos, 0, y_pos);
	}

	public bool moveRight() {
		if (map.isValidLocation (x_pos + 1, y_pos)) {
			x_pos++;
			updatePos ();
			return true;
		}
		return false;
	}

	public bool moveLeft() {
		if (map.isValidLocation (x_pos - 1, y_pos)) {
			x_pos--;
			updatePos ();
			return true;
		}
		return false;
	}

	public bool moveUp() {
		if (map.isValidLocation (x_pos, y_pos + 1)) {
			y_pos++;
			updatePos ();
			return true;
		}
		return false;
	}

	public bool moveDown() {
		if (map.isValidLocation (x_pos, y_pos - 1)) {
			y_pos--;
			updatePos ();
			return true;
		}
		return false;
	}
}
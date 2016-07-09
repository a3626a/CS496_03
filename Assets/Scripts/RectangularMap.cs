using System;

public class RectangularMap : Map {

	private int width;
	private int height;

	bool isValidLocation(int x, int y) {
		if (x >= -width && x <= width) {
			if (y >= 0 && y <= height) {
				return true;
			}
		}
		return false;
	}	

}



// Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

function isPointInCircle(xPoint, yPoint, xCircle, yCircle, rCircle) {
	return ((xPoint - xCircle) * (xPoint - xCircle)) + ((yPoint - yCircle) * (yPoint - yCircle)) <= rCircle * rCircle; 
}

function isInCircleAndOutsideRect(x, y) {
	if (isPointInCircle(x, y, 1, 1, 3)) {
		if (((x < -1) || (x > 5) || (y > 1) || (y < -1)))
		{
			return true;
		}
	}

	return false;
}

console.log(isInCircleAndOutsideRect(-100, -100));
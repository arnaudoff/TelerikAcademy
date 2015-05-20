// Write an expression that checks if given point P(x, y) is within a circle K(O, 5).

function isPointInCircle(xPoint, yPoint, xCircle, yCircle, rCircle) {
	return ((xPoint - xCircle) * (xPoint - xCircle)) + ((yPoint - yCircle) * (yPoint - yCircle)) <= rCircle * rCircle; 
}

console.log(isPointInCircle(0.9, -1.93, 0, 0, 5));
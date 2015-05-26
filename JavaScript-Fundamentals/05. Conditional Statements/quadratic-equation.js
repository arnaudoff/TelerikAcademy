/*
	Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
	Calculates and prints its real roots.
	
	Note: Quadratic equations may have 0, 1 or 2 real roots.
*/

function solveQuadraticEquation(a, b, c) {
	if (a === 0) {
		return -c / b;
	} else {
		discriminant = b * b - 4 * a * c;
		if (discriminant < 0 ) {
			return 'no real roots';
		} else {
			if (discriminant === 0) {
				x = -b / (2 * a);
				return 'x1 = x2 = ' + x;
			} else {
				x1 = (-b - Math.sqrt(discriminant)) / (2 * a);
				x2 = (-b + Math.sqrt(discriminant)) / (2 * a);
				return 'x1 = ' + x1 + ' ; ' + 'x2 = ' + x2;
			}
		}
	}
}

console.log(solveQuadraticEquation(2, 5, -3));
console.log(solveQuadraticEquation(-1, 3, 0));
console.log(solveQuadraticEquation(-0.5, 4, -8));
console.log(solveQuadraticEquation(5, 2, 8));
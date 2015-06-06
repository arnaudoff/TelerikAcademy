/* 
    Write functions for working with shapes in standard Planar coordinate system.
        Points are represented by coordinates P(X, Y)
        Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
    Calculate the distance between two points.
    Check if three segment lines can form a triangle
*/

var vertexA,
    vertexB,
    vertexC,
    sideA,
    sideB,
    sideC;

function createPoint(x, y) {
    return {
        'x' : x,
        'y' : y
    };
}

function createLine(point1, point2) {
    return {
        'p1' : point1,
        'p2' : point2,
        'length' : calculateDistance(point1, point2)
    };
}

function calculateDistance(point1, point2) {
    return Math.sqrt((point1.x - point2.x) * (point1.x - point2.x) +
        (point1.y - point2.y) * (point1.y - point2.y));
}

function canFormTriangle(sideA, sideB, sideC) {
    if ((sideA.length + sideB.length > sideC.length) &&
        (sideA.length + sideC.length > sideB.length) &&
        (sideB.length + sideC.length > sideA.length)) {
        return true;
    } else {
        return false;
    }
}

vertexA = createPoint(1, 1);
vertexB = createPoint(5, 1);
vertexC = createPoint(3, 4);

sideA = createLine(vertexB, vertexC);
sideB = createLine(vertexA, vertexC);
sideC = createLine(vertexA, vertexB);

console.log(canFormTriangle(sideA, sideB, sideC));
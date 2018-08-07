function randomState(width, height) {
	// Declare a new array, will be a 2D array
	var board = [];

	for (var i = 0; i < height; i++) {
		// Push a new line onto the array
		board.push([]);

		// Add to the new line with a random number (0 or 1)
		for (var j = 0; j < width; j++) {
			board[i].push(Math.round(Math.random()));
		}
	}

	return board;
}

var w = 5, h = 5;
console.log("Width = " + w);
console.log("Height = " + h);
var board = randomState(w, h);

for (var i = 0; i < board.length; i++) {
	console.log(board[i]);
}
function randomState(width, height) {
	var board = [];

	for (var i = 0; i < height; i++) {
		board.push([]);

		for (var j = 0; j < width; j++) {
			board[i].push(Math.round(Math.random()));
		}
	}

	return board;
}

function render(boardState, strAlive = '#', strDead = ' ') {

	// Calculate the border and surround the board.
	var border = "-".repeat(boardState[0].length * 2 + 1);
	console.log(border);

	// Print the board.
	// 1. Iterate through each row
	// 2. Map each cell, dependent on the state
	// 3. Concat the string onto the same line
	for (var i = 0; i < boardState.length; i++) {
		var line = boardState[i].map(x => x == 1 ? strAlive : strDead);

		// Surround the board vertically too
		console.log("|" + line.join(" ") + "|");
	}

	console.log(border);
}

render(randomState(9, 9));
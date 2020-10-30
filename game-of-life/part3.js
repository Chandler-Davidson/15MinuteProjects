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
	strAlive 

	var border = "-".repeat(boardState[0].length * 2 + 1);
	console.log(border);

	for (var i = 0; i < boardState.length; i++) {
		var line = boardState[i].map(x => x == 1 ? strAlive : strDead);
		console.log("|" + line.join(" ") + "|");
	}

	console.log(border);
}

function nextBoardState(board) {

	// Iterate through the entire board, leaving out corners
	for (var i = 1; i < board.length-1; i++) {
		for (var j = 1; j < board[i].length-1; j++) {
			
			// Count the adjacent neighbors
			let neighbors = 0;
			for (var q = -1; q <= 1; q++) {
				for (var k = -1; k <= 1; k++) {
					neighbors += board[i + q][j + k];
				}
			}

			if (neighbors < 1)			// Underpopulation
				board[i][j] = 0;
			// else if (neighbors >= 2)	// Just right, leave alone
				// Do nothing
			else if (neighbors > 3)		// Overpopulation
				board[i][j] = 0;
			else if (neighbors == 3)	// Reproduction
				board[i][j] = 1;
		}
	}

	return board;
}

var board = randomState(9, 9);
render(board);
render(nextBoardState(board));
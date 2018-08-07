function randomState(width, height) {
	var board = [];

	for (var i = 0; i < height; i++) {
		board.push([]);

		for (var j = 0; j < width; j++) {
			// board[i].push(Math.round(Math.random()));

			var rnd = Math.floor(Math.random() * 6);
			if (rnd == 0)
				board[i].push(1);
			else
				board[i].push(0);
		}
	}

	return board;
}

function render(boardState, strAlive = '#', strDead = ' ') {
	var border = "-".repeat(boardState[0].length * 2 + 1);
	console.log(border);

	for (var i = 0; i < boardState.length; i++) {
		var line = boardState[i].map(x => x == 1 ? strAlive : strDead);
		console.log("|" + line.join(" ") + "|");
	}

	console.log(border);
}

function nextBoardState(board) {
	var newBoard = board;

	// Iterate through the entire board, leaving out corners
	for (var i = 1; i < board.length-1; i++) {
		for (var j = 1; j < board[i].length-1; j++) {
			
			// Count the adjacent neighbors
			var neighbors = 0;
			for (var q = -1; q <= 1; q++) {
				for (var k = -1; k <= 1; k++) {
					neighbors += board[i + q][j + k];
				}
			}

			console.log(neighbors);


			if (neighbors <= 1)			// Underpopulation
				newBoard[i][j] = 0;
			// else if (neighbors >= 2)	// Just right, leave alone
				// Do nothing
			else if (neighbors == 3)	// Reproduction
				newBoard[i][j] = 1;
			else if (neighbors > 3)		// Overpopulation
				newBoard[i][j] = 0;
		}
	}

	return newBoard;
}

function circleOfLife(size, pace) {
	var board = randomState(size, size);
	var anyAliveCell = board.some(row => row.some(cell => cell == 1));

	// Loop until no alive cells
	// Bit too much to explain:
	// 1. Self executing function
	// 2. Set pace game loop using setTimeout
	// 3. Update and render each loop
	(function gameLoop() {
		setTimeout(function() {
			process.stdout.write('\033c');
			render(board);
			board = nextBoardState(board);

			if (anyAliveCell)
				gameLoop();
		}, pace);
	})();
}

circleOfLife(10, 100);
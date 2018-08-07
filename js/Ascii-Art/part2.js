var Caman = require('caman').Caman;

Caman("./ascii-pineapple.jpg", function() {

	// Get the pixels of the image, returns a 1D array
	var flatPixels = this.originalVisiblePixels();

	// Declare a new array that will hold subsequent arrays,
	// this will be the matrix of pixels.
	var pixelMatrix = [];

	// Iterate through each pixel group:
	// Caman stores the pixels as: [A, R, G, B]
	for (var i = 0; i < flatPixels.length; i += 4) {

		// 1. Select the last three pixels in the group
		// 2. Push the new array onto the matrix
		pixelMatrix.push(
			flatPixels.slice(i, i + 3));
	}

	// Now we are able to iterate through the matrix.
	for (var i = 0; i < pixelMatrix.length; i++) {
		for (var j = 0; j < pixelMatrix[i].length; j++) {
			var pixel = pixelMatrix[i][j];
			// Do something with the pixel...
		}
	}
});
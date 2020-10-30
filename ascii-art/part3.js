var Caman = require('caman').Caman;

Caman("./ascii-pineapple.jpg", function() {

	var flatPixels = this.originalVisiblePixels();
	var pixelMatrix = [];

	for (var i = 0; i < flatPixels.length; i += 4) {
		pixelMatrix.push(
			flatPixels.slice(i, i + 3));
	}

	// Option 1: Imperative
	for (var i = 0; i < pixelMatrix.length; i++) {
		// Get the inner array (a single pixel).
		var pixel = pixelMatrix[i];
		var r = pixel[0];
		var g = pixel[1];
		var b = pixel[2];

		// Three ways of mapping RGB to brightness,
		// we're sticking with the average brightness.
		var avg = (pixel[0] + pixel[1] + pixel[2]) / 3;
		var lightness = Math.max(r, g, b) + Math.min(r, g, b) / 2;
		var luminosity = 0.21 * r + 0.72 * g + 0.07 * b;
	}

	// Option 2: Functional
	var avgBrightness = pixelMatrix.map(x => (x[0] + x[1] + x[2]) / 3);
	console.log(avgBrightness[0]);
});
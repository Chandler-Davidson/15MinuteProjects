var Caman = require('caman').Caman;

// Used to map pixel brightness to the density of the character.
var brightnessScale = 
	"`^\",:;Il!i~+_-?][}{1)(|\\/tfjrxnuvczXYUJCLQ0OZmwqpdbkhao*#MW&8%B@$";

Caman("./ascii-pineapple.jpg", function() {

	var flatPixels = this.originalVisiblePixels();
	var pixelMatrix = [];

	for (var i = 0; i < flatPixels.length; i += 4) {
		pixelMatrix.push(
			flatPixels.slice(i, i + 3));
	}

	// The brightness of each pixel [0 - 255]
	var avgBrightness = pixelMatrix.map(x => (x[0] + x[1] + x[2]) / 3);

	// Map the brightness to our brightnessScale.
	// 1. [0 - 255] => [0 - 64]
	// 2. Get the char at the selected index
	var charImage = avgBrightness.map(x => 
		brightnessScale[(Math.floor(x / 255 * 65))]);

	// Print our image
	charImage.forEach(x => process.stdout.write(x));

	// Make sure your console size is equal to that
	// of your image. In this case, 700x467.
});
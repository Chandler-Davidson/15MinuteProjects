var Caman = require('caman').Caman;

// Load the image then operate on the image
Caman("./ascii-pineapple.jpg", function() {
	let w = this.imageWidth();
	let h = this.imageHeight();

	console.log(`Successfully loaded image!` +
		`\nImage size: ${w} x ${h}`);
});
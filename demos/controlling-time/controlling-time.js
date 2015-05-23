var currentTime = new Date();

function doStuff() {
	currentTime = new Date();
}

doStuff();
setTimeout(doStuff, 3000);
setTimeout(doStuff, 5000);
function ExampleObject(id) {
	this.id = id;
	this.title = 'example object(' + id + ')';
}

function doStuff(example) {
	console.log(example.title);
}

function executeDemo() {
	for(var i = 0; i <= 1000; i++) {
		doStuff(new ExampleObject(i));
	}
}

$(function() {
	$('#goBabyGo').on('click', executeDemo);
});
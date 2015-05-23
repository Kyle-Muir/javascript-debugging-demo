var arrayOfItems = [1, 2, 4, 5, 6, 7, 8, 9, 10];

function executeDemo() {
	//Breakpoint line 5 and step in. When non-blackboxed it will step into jQuery, when blackboxed it will step into your custom code.
	$.each(arrayOfItems, function(key, value) {
		console.log(value);
	});
}

$(function() {
	$('#goBabyGo').on('click', executeDemo);
});
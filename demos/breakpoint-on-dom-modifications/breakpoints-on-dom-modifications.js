function executeDemo() {
	$('#domModificationDemo').append('<span></span>');
}

$(function() {
	$('#goBabyGo').on('click', executeDemo);
});
function executeDemo() {
    $('head').append('<script type="text/javascript" src="dynamic-script-with-source-url.js"></script>');
	$('head').append('<script type="text/javascript" src="dynamic-script-no-source-url.js"></script>');
}

$(function() {
    $('#goBabyGo').on('click', executeDemo);
});

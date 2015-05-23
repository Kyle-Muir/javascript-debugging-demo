function executeDemo() {
	var baseUrl = 'http://localhost:53173';
	$.get(baseUrl + '/api/echo').success(function(data){
		console.log(data);
	});
}

$(function() {
	$('#goBabyGo').on('click', executeDemo);
});
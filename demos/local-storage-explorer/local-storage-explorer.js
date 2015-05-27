function executeDemo() {
	var baseUrl = 'http://localhost:53173';
	$.get(baseUrl + '/api/largedataset').success(function(data) {
    	localStorage.setItem('data', JSON.stringify(data));
	});
}

$(function() {
    executeDemo();
});

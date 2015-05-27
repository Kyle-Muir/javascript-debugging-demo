function executeDemo() {
    $.get('http://localhost:53173/Content/dynamic-script-with-source-url.js').success(function(resp){
    	//NOTE: Never do this other than for demos. Eval is generally pretty evil.
    	eval(resp);
    });
    $.get('http://localhost:53173/Content/dynamic-script-no-source-url.js').success(function(resp){
    	//NOTE: Never do this other than for demos. Eval is generally pretty evil.
    	eval(resp);
    });
}

$(function() {
    $('#goBabyGo').on('click', executeDemo);
});

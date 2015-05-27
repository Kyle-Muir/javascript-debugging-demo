function executeDemo() {
    $.get('http://localhost:53173/Content/dynamic-script-with-source-url.js').success(function(resp){eval(resp); console.log(resp)})
    $.get('http://localhost:53173/Content/dynamic-script-no-source-url.js').success(function(resp){eval(resp); console.log(resp)})
}

$(function() {
    $('#goBabyGo').on('click', executeDemo);
});

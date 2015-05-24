function executeDemo() {
    //do some custom stuff here
    console.log('hello world!');
}

$(function() {
    $('#goBabyGo').on('click', executeDemo);
});

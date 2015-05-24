function executeConsoleLogDemo() {
    var baseUrl = 'http://localhost:53173';
    $.get(baseUrl + '/api/largedataset').success(function(data) {
        console.log('Console.log of a single item: %O', data[0]);

        console.log('console.log of the entire data set');
        console.log(data);

        console.log('Default table data:');
        console.table(data);

        console.log('Table data with just id and title shown:');
        //Note: column headers are case sensitive
        console.table(data, ['Id', 'Title']);

        console.log("%cThis is %s gross, I rate it %d/%d mate.", "color:orange; background:blue; font-size: 16pt", 'pretty', 8, 8.00000125);
    });
}

function callMeMaybe() {
    console.count('Call me maybe called');
}

function logMeIn(userName) {
    console.count('log me in called for "' + userName + '"');
}

function executeConsoleCountDemo() {
    for (var i = 0; i < 10; i++) {
        callMeMaybe(i);
    }
    logMeIn('Kyle');
    logMeIn('Kyle');
    logMeIn('Ben');
    logMeIn('Ben');
    logMeIn('Kyle');
    logMeIn('Yono');
}

function executeConsoleTimeDemo() {
    console.time('adding lots of items to an array');
    var array = new Array(1000000);
    for (var i = array.length - 1; i >= 0; i--) {
        array[i] = new Object();
    }
    console.timeEnd('adding lots of items to an array');
}

function executeDebuggerDemo() {
    debugger;
    console.log('then you can breakpoint this.');
}

$(function() {
    $('#consoleLog').on('click', executeConsoleLogDemo);
    $('#consoleCount').on('click', executeConsoleCountDemo);
    $('#consoleTime').on('click', executeConsoleTimeDemo);
    $('#debuggerExample').on('click', executeDebuggerDemo);
});

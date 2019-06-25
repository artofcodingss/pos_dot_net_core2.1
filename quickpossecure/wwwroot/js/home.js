var todayFullDate = new Date();
var todayShortDate = new Date().toLocaleDateString('en-GB');
let alldaysname = ['SUNDAY', 'MONDAY', 'TUESDAY', 'WEDNESDAY', 'THURSDAY', 'FRIDAY', 'SATUSDAY'];
const allmonthNames = ["January", "February", "March", "April", "May", "June",
    "July", "August", "September", "October", "November", "December"
];

function getDayName(date) {
    return alldaysname[date.getDay()];
}
function getMonthName(date)
{
    return allmonthNames[date.getMonth()]
}
var todayDayNumber = todayFullDate.getDate();
var todayDayName = getDayName(todayFullDate);
var thisMonthNumber = (todayFullDate.getMonth() + 1);
var thisMonthName = getMonthName(todayFullDate);
var thisYear = todayFullDate.getFullYear();


function showLoader() {
    $('head').append('<style>'
        + '.loading {'
        + 'position: fixed;'
        + 'top: 0;'
        + 'left: 0;'
        + 'width: 100%;'
        + 'height: 100%;'
        + 'background: black;'
        + 'z-index: 99999;'
        + 'opacity:0.9;'
        + '}'

        + '.loading-text {'
        + 'position: absolute;'
        + 'top: 0;'
        + 'bottom: 0;'
        + 'left: 0;'
        + 'right: 0;'
        + 'margin: auto;'
        + 'text-align: center;'
        + 'width: 100%;'
        + 'height: 100px;'
        + 'line-height: 100px;'
        + '}'
        + '.loading-text span {'
        + 'display: inline-block;'
        + 'margin: 0 5px;'
        + 'color: #fff;'
        + 'font-family: "Quattrocento Sans", sans-serif;'
        + '}'
        + '.loading-text span:nth-child(1) {'
        + '-webkit-filter: blur(0px);'
        + 'filter: blur(0px);'
        + '-webkit-animation: blur-text 1.5s 0s infinite linear alternate;'
        + 'animation: blur-text 1.5s 0s infinite linear alternate;'
        + '}'
        + '.loading-text span:nth-child(2) {'
        + '-webkit-filter: blur(0px);'
        + 'filter: blur(0px);'
        + '-webkit-animation: blur-text 1.5s 0.2s infinite linear alternate;'
        + 'animation: blur-text 1.5s 0.2s infinite linear alternate;'
        + '}'
        + '.loading-text span:nth-child(3) {'
        + '-webkit-filter: blur(0px);'
        + 'filter: blur(0px);'
        + '-webkit-animation: blur-text 1.5s 0.4s infinite linear alternate;'
        + 'animation: blur-text 1.5s 0.4s infinite linear alternate;'
        + '}'
        + '.loading-text span:nth-child(4) {'
        + '-webkit-filter: blur(0px);'
        + 'filter: blur(0px);'
        + '-webkit-animation: blur-text 1.5s 0.6s infinite linear alternate;'
        + 'animation: blur-text 1.5s 0.6s infinite linear alternate;'
        + '}'
        + '.loading-text span:nth-child(5) {'
        + '-webkit-filter: blur(0px);'
        + 'filter: blur(0px);'
        + '-webkit-animation: blur-text 1.5s 0.8s infinite linear alternate;'
        + 'animation: blur-text 1.5s 0.8s infinite linear alternate;'
        + '}'
        + '.loading-text span:nth-child(6) {'
        + '-webkit-filter: blur(0px);'
        + 'filter: blur(0px);'
        + '-webkit-animation: blur-text 1.5s 1s infinite linear alternate;'
        + 'animation: blur-text 1.5s 1s infinite linear alternate;'
        + '}'
        + '.loading-text span:nth-child(7) {'
        + '-webkit-filter: blur(0px);'
        + 'filter: blur(0px);'
        + '-webkit-animation: blur-text 1.5s 1.2s infinite linear alternate;'
        + 'animation: blur-text 1.5s 1.2s infinite linear alternate;'
        + '}'

        + '@@-webkit-keyframes blur-text {'
        + '0% {'
        + '-webkit-filter: blur(0px);'
        + 'filter: blur(0px);'
        + '}'
        + '100% {'
        + '-webkit-filter: blur(4px);'
        + 'filter: blur(4px);'
        + '}'
        + '}'

        + '@@keyframes blur-text {'
        + '0% {'
        + '-webkit-filter: blur(0px);'
        + 'filter: blur(0px);'
        + '}'
        + '100% {'
        + '-webkit-filter: blur(4px);'
        + 'filter: blur(4px);'
        + '}'
        + '}'
        + '</style>');
    $('body').prepend('<div id="loader" class="loading">'
        + '<div class="loading-text" >'
        + '<span class="loading-text-words">L</span>'
        + '<span class="loading-text-words">O</span>'
        + '<span class="loading-text-words">A</span>'
        + '<span class="loading-text-words">D</span>'
        + '<span class="loading-text-words">I</span>'
        + '<span class="loading-text-words">N</span>'
        + '<span class="loading-text-words">G</span>'
        + '</div>'
        + '</div>');
}
function hideLoader() {
    $("#loader").remove();
}

function CustomConsole(data)
{
    console.log(data);
}



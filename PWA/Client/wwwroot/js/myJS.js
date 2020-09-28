function x() {
    document.getElementById("sidenavWrapper").classList.add("nav-active");
    document.getElementById("headerArea").classList.add("header-out");
    document.getElementById("footerNav").classList.add("footer-out");
    document.getElementsByClassName("sidenav-black-overlay").classList.add("active");

    //document.getElementById("demop").innerHTML = "JavaScript Method invoked";
    console.log("Hello World");
}

// Dark Mode JS
function darkMode() {
    console.log("Hello World");

    var toggleSwitch = document.getElementById('darkSwitch');
    var currentTheme = localStorage.getItem('theme');

    if (currentTheme) {
        document.documentElement.setAttribute('data-theme', currentTheme);
        if (currentTheme === 'dark') {
            if (toggleSwitch) {
                toggleSwitch.checked = true;
            }
        }
    }

    function switchTheme(e) {
        if (e.target.checked) {
            document.documentElement.setAttribute('data-theme', 'dark');
            localStorage.setItem('theme', 'dark');
        } else {
            document.documentElement.setAttribute('data-theme', 'light');
            localStorage.setItem('theme', 'light');
        }
    }
    if (toggleSwitch) {
        toggleSwitch.addEventListener('change', switchTheme, false);
    }
}
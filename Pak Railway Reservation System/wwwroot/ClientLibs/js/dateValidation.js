// Function to set the minimum and maximum dates for the date picker
function setMinMaxDates() {
    var today = new Date();
    var dd = String(today.getDate()).padStart(2, '0');
    var mm = String(today.getMonth() + 1).padStart(2, '0'); // January is 0!
    var yyyy = today.getFullYear();

    today = yyyy + '-' + mm + '-' + dd;

    var threeMonthsLater = new Date(today);
    threeMonthsLater.setMonth(threeMonthsLater.getMonth() + 3);
    var maxDate = threeMonthsLater.toISOString().split('T')[0];

    document.getElementById("date").min = today;
    document.getElementById("date").max = maxDate;
}

// Call the function when the page is loaded
window.onload = setMinMaxDates;
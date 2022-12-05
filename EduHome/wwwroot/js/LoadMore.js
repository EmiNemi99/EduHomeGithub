let skipcount = 6;
skipcount += 6;

$(document).on("click", "#loadmore", function () {
    $.ajax({
        url: "/Courses/LoadMore/",
        type: "GET",
        data: { "skip": skipcount},
        
        success: function (response) {
            $("#myCourses").append(response);
        }
    });;
});

(function() {
    $(function() {
        $.ajax({
            method: "GET",
            url: "/Band/JsonList"
        }).done(function (data) {
            data.forEach(function (band) {
                $newLi = $("<li>" + band.name + " (" + band.year + ")" + "</li>")
                $newUl = $("<ul></ul>")
                band.members.forEach(function (member) {
                    $newSubLi = $("<li>" + member.name + ", " + member.age + ", " + (member.gender == 0 ? "male" : "female") + ", " + (member.alive == true ? "alive" : "dead") + "</li>")
                    $newUl.append($newSubLi);
                })
                $newLi.append($newUl);
                $("#bands").append($newLi);
            })

        })
    });
})();
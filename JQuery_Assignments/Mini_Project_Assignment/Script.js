let currentPage = 1;
let limit = 3;
let editMode = false;

$(document).ready(function () {

    loadStudents();
    $("#saveBtn").click(function () {

        let name = $("#name").val().trim();
        let age = $("#age").val();
        let grade = $("#grade").val();
        let id = $("#studentId").val();

        if (name === "" || age === "" || grade === "") {
            alert("Please fill all fields");
            return;
        }

        let student = {
            name: name,
            age: age,
            grade: grade
        };

        if (editMode) {
            $.ajax({
                url: "http://localhost:3000/students/" + id,
                type: "PUT",
                contentType: "application/json",
                data: JSON.stringify(student),
                success: function () {
                    alert("Student Updated");
                    resetForm();
                    loadStudents();
                }
            });
        }

        else {
            $.ajax({
                url: "http://localhost:3000/students",
                type: "POST",
                contentType: "application/json",
                data: JSON.stringify(student),
                success: function () {
                    alert("Student Added");
                    resetForm();
                    loadStudents();
                }
            });
        }
    });

    $("#search").keyup(function () {
        currentPage = 1;
        loadStudents();
    });

    $("#filterGrade").change(function () {
        currentPage = 1;
        loadStudents();
    });

    $("#prevBtn").click(function () {
        if (currentPage > 1) {
            currentPage--;
            loadStudents();
        }
    });

    $("#nextBtn").click(function () {
        currentPage++;
        loadStudents();
    });

});

function loadStudents() {

    $.get("http://localhost:3000/students", function (data) {

        let searchText = $("#search").val().toLowerCase();
        let gradeFilter = $("#filterGrade").val();

        let filtered = data.filter(function (student) {
            return student.name.toLowerCase().includes(searchText);
        });

        if (gradeFilter !== "") {
            filtered = filtered.filter(function (student) {
                return student.grade === gradeFilter;
            });
        }

        let start = (currentPage - 1) * limit;
        let paginated = filtered.slice(start, start + limit);

        $("#studentTable").empty();

        paginated.forEach(function (student) {

            $("#studentTable").append(`
                <tr>
                    <td>${student.name}</td>
                    <td>${student.age}</td>
                    <td>${student.grade}</td>
                    <td>
                        <button onclick="editStudent('${student.id}')">Edit</button>
                        <button onclick="deleteStudent('${student.id}')">Delete</button>
                    </td>
                </tr>
            `);

        });

        $("#pageInfo").text("Page: " + currentPage);
    });
}

function editStudent(id) {

    $.get("http://localhost:3000/students/" + id, function (data) {

        $("#studentId").val(data.id);
        $("#name").val(data.name);
        $("#age").val(data.age);
        $("#grade").val(data.grade);

        editMode = true;
    });
}

function deleteStudent(id) {

    if (confirm("Are you sure?")) {

        $.ajax({
            url: "http://localhost:3000/students/" + id,
            type: "DELETE",
            success: function () {
                alert("Student Deleted");
                loadStudents();
            }
        });
    }
}

function resetForm() {
    $("#studentId").val("");
    $("#name").val("");
    $("#age").val("");
    $("#grade").val("");
    editMode = false;
}
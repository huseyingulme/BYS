document.getElementById("courseSelectionForm").addEventListener("submit", async function (e) {
    e.preventDefault();

    const selectedCourses = Array.from(document.getElementById("courses").selectedOptions).map(option => option.value);

    const response = await fetch("https://localhost:5001/api/students/1/courses", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ courses: selectedCourses }),
    });

    if (response.ok) {
        alert("Dersler başarıyla kaydedildi!");
    } else {
        alert("Bir hata oluştu.");
    }
});

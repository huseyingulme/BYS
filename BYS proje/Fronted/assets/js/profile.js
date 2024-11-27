document.getElementById("profileForm").addEventListener("submit", async function (e) {
    e.preventDefault();

    const profileData = {
        firstName: document.getElementById("firstName").value,
        lastName: document.getElementById("lastName").value,
        email: document.getElementById("email").value,
    };

    const response = await fetch("https://localhost:5001/api/students/1", {
        method: "PUT",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(profileData),
    });

    if (response.ok) {
        alert("Profil başarıyla güncellendi!");
    } else {
        alert("Bir hata oluştu.");
    }
});

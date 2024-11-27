document.addEventListener("DOMContentLoaded", function () {
    const loginForm = document.getElementById("loginForm");

    loginForm.addEventListener("submit", async function (e) {
        e.preventDefault();

        const email = document.getElementById("email").value.trim();
        const password = document.getElementById("password").value.trim();

        if (!email || !password) {
            alert("Lütfen tüm alanları doldurunuz!");
            return;
        }

        try {
            const response = await fetch("https://localhost:5001/api/auth/login", {
                method: "POST",
                headers: {
                    "Content-Type": "application/json",
                },
                body: JSON.stringify({
                    email: email,
                    password: password,
                }),
            });

            if (response.ok) {
                const result = await response.json();
                localStorage.setItem("token", result.token); // JWT'yi sakla
                window.location.href = "dashboard.html"; // Kullanıcıyı yönlendir
            } else {
                const errorData = await response.json();
                alert(`Hata: ${errorData.message}`);
            }
        } catch (error) {
            console.error("Giriş sırasında hata oluştu:", error);
            alert("Bir hata oluştu, lütfen tekrar deneyiniz.");
        }
    });
});

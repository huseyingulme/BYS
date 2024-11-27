document.getElementById("loginForm").addEventListener("submit", async function (e) {
    e.preventDefault();

    const email = document.getElementById("email").value;
    const password = document.getElementById("password").value;

    try {
        const response = await fetch("https://localhost:5001/api/auth/login", {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({ email, password }),
        });

        if (response.ok) {
            const data = await response.json();
            localStorage.setItem("token", data.token);
            window.location.href = "dashboard.html";
        } else {
            alert("Giriş başarısız! Lütfen bilgilerinizi kontrol edin.");
        }
    } catch (error) {
        console.error("Giriş işlemi sırasında bir hata oluştu:", error);
    }
});

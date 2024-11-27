const BASE_URL = "https://localhost:5001/api";

async function login(email, password) {
    const response = await fetch(`${BASE_URL}/auth/login`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ email, password }),
    });

    if (response.ok) {
        return response.json();
    } else {
        const error = await response.json();
        throw new Error(error.message);
    }
}

async function getCourses() {
    const response = await fetch(`${BASE_URL}/courses`, { method: "GET" });
    return response.json();
}

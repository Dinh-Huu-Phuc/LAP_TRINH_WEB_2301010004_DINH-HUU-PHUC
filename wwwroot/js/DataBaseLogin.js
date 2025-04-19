console.log("✅ File DataBaseLogin.js đã được load");

document.addEventListener("DOMContentLoaded", function () {
    const form = document.getElementById('registerForm');

    if (form) {
        form.addEventListener('submit', async function (e) {
            e.preventDefault();

            const username = document.getElementById('username').value;
            const password = document.getElementById('password').value;

            const response = await fetch('https://localhost:5001/auth/register', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({ username, password })
            });

            const result = await response.text();
            document.getElementById('result').innerText = result;
        });
    }
});

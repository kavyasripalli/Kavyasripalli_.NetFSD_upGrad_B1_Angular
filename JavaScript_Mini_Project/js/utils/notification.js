export function showNotification(message) {
  const box = document.getElementById("notification");

  box.textContent = message;
  box.style.display = "block";

  setTimeout(() => {
    box.style.display = "none";
  }, 6000);
}
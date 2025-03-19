// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

document.addEventListener("DOMContentLoaded", function () {
  const currentUrl = window.location.href;
  const navLinks = document.querySelectorAll(".navbar .nav-link");

  navLinks.forEach((link) => {
    if (currentUrl.includes(link.getAttribute("href"))) {
      link.classList.add("active");
    }
  });
});

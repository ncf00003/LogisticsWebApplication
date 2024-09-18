// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function hideToc() {
    var Toc = document.getElementById("TableOfContents");
    if (Toc.style.display === "none") {
        Toc.style.display = "block";
    }
    else {
        Toc.style.display = "none";
    }
}

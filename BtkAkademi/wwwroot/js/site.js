// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// JavaScript kodu (örneğin, bir script etiketi içinde veya bir .js dosyasında)
const selectElement = document.getElementById('mySelect');

// Başlangıç ve bitiş değerlerini belirle
const startValue = 18;
const endValue = 30;

// Döngü ile option elementlerini oluştur ve ekle
for (let i = startValue; i <= endValue; i++) {
    const option = document.createElement('option');
    option.value = i;
    option.text = i;
    selectElement.appendChild(option);
}
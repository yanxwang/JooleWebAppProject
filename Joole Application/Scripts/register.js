﻿const image_input = document.querySelector("#image-input");
var uploaded_image = '';

image_input.addEventListener("change", function() {
    const reader = new FileReader();
    reader.addEventListener("load", () => {
        uploaded_image = reader.result;
        document.querySelector("#dispaly_image").style.backgroundImage = `url(${uploaded_image})`;
    });
    reader.readAsDataURL(this.files[0]);
})
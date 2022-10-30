//1
let range1 = document.querySelectorAll('.range-slider1 input');
progress1 = document.querySelector('.range-slider1 .progress');
let gap = 1;
const inputValue1 = document.querySelectorAll('.numberVal1 input');


range1.forEach(input => {
    input.addEventListener('input', e =>{
        let minrange = parseInt(range1[0].value),
        maxrange = parseInt(range1[1].value);
        if (maxrange - minrange < gap) {
            if (e.target.className === 'range-min'){
                range1[0].value = maxrange - gap;
            }
            else {
                range1[1].value = minrange + gap;
            }          
        }
        else{
            progress1.style.left = (minrange/range1[0].max) * 100 + "%";
            progress1.style.right = 100 - (maxrange/range1[1].max) * 100 + '%';
            inputValue1[0].value = minrange;
            inputValue1[1].value = maxrange;
        }
    })
})

//2
let range2 = document.querySelectorAll('.range-slider2 input');
progress2 = document.querySelector('.range-slider2 .progress');
const inputValue2 = document.querySelectorAll('.numberVal2 input');


range2.forEach(input => {
    input.addEventListener('input', e =>{
        let minrange = parseInt(range2[0].value),
        maxrange = parseInt(range2[1].value);
        if (maxrange - minrange < gap) {
            if (e.target.className === 'range-min'){
                range2[0].value = maxrange - gap;
            }
            else {
                range2[1].value = minrange + gap;
            }          
        }
        else{
            progress2.style.left = (minrange/range2[0].max) * 100 + "%";
            progress2.style.right = 100 - (maxrange/range2[1].max) * 100 + '%';
            inputValue2[0].value = minrange;
            inputValue2[1].value = maxrange;
        }
    })
})

//3
let range3 = document.querySelectorAll('.range-slider3 input');
progress3 = document.querySelector('.range-slider3 .progress');
const inputValue3 = document.querySelectorAll('.numberVal3 input');

range3.forEach(input => {
    input.addEventListener('input', e =>{
        let minrange = parseInt(range3[0].value),
        maxrange = parseInt(range3[1].value);
        if (maxrange - minrange < gap) {
            if (e.target.className === 'range-min'){
                range3[0].value = maxrange - gap;
            }
            else {
                range3[1].value = minrange + gap;
            }          
        }
        else{
            progress3.style.left = (minrange/range3[0].max) * 100 + "%";
            progress3.style.right = 100 - (maxrange/range3[1].max) * 100 + '%';
            inputValue3[0].value = minrange;
            inputValue3[1].value = maxrange;
        }
    })
})


//4
let range4 = document.querySelectorAll('.range-slider4 input');
progress4 = document.querySelector('.range-slider4 .progress');
const inputValue4 = document.querySelectorAll('.numberVal4 input');



range4.forEach(input => {
    input.addEventListener('input', e =>{
        let minrange = parseInt(range4[0].value),
        maxrange = parseInt(range4[1].value);
        if (maxrange - minrange < gap) {
            if (e.target.className === 'range-min'){
                range4[0].value = maxrange - gap;
            }
            else {
                range4[1].value = minrange + gap;
            }          
        }
        else{
            progress4.style.left = (minrange/range4[0].max) * 100 + "%";
            progress4.style.right = 100 - (maxrange/range4[1].max) * 100 + '%';
            inputValue4[0].value = minrange;
            inputValue4[1].value = maxrange;
        }
    })
})

    

       
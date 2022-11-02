//实现模糊查询================================================
let keyword = document.querySelector('.keyword'); 
let searchHelper = document.querySelector('.search-helper');

//定义数组，存储搜索的内容
let searchArr = ['Applephone', 'Huaweiphone', 'Xiaomiphone', 'XiaomiTV', 'XiaomiIpad', 'Ipad', 'Apple12', 'Apple13', 'AppleWatch'];
//给输入框绑定内容改变事件
keyword.oninput = function(){
    searchHelper.innerHTML = '';
    for(let i = 0; i < searchArr.length; i++){
        if(searchArr[i].indexOf(keyword.value) != -1){
            searchHelper.innerHTML += '<p>' + searchArr[i] + '</p>';
            searchHelper.style.display = 'block';           
        }
    }
}


keyword.onblur = function() {
    searchHelper.style.display = "none";
}










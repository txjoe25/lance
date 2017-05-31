

// Side navigation
$('#grab').on('loadstart', function (event) {
    $(this).addClass('load');
  });
  $('#grab').on('canplay', function (event) {
    $(this).removeClass('load');
    $(this).attr('poster', '');
  });
var myVar = setInterval(function(){ time() }, 1000);
function time() {
    var d = new Date();
    var t = d.toLocaleTimeString();
    var dd = d.toLocaleDateString();
    document.getElementById("Time").innerHTML = t;
    document.getElementById("Time").style.fontFamily = " 'Orbitron', sans-serif;";
    document.getElementById("Date").innerHTML = dd;
}
$( function() {
    $( "#date" ).datepicker({ minDate: 1, maxDate: "+1Y" });
  } );
function w3_open() {
    document.getElementById("mySidebar").style.display = "inline-block";
    document.getElementById("social").style.display = "none";
}
function w3_close() {
    document.getElementById("mySidebar").style.display = "none";
    document.getElementById("social").style.display = "inline-block";
}
function mouseOver() {
    document.getElementById("social").addEventListener("mouseover", mouseOver);
    document.getElementById("social").style.transform="rotate(7deg)";
}
function mouseOut() {
    document.getElementById("social").addEventListener("mouseout", mouseOut);
    document.getElementById("social").style.transform="rotate(-7deg)";
}
function cond(){
    page = document.getElementById("hob");
    page.addEventListener("mouseover", mouseOver);
    page.style.width="3em"; 
    page.style.position="absolute";
    page.style.left="3em";    
    page.style.top="302vh";       
    }   
function cond2(){
    page = document.getElementById("pro");
    page.addEventListener("mouseover", mouseOver);
    page.style.width="3em"; 
    page.style.position="absolute";
    page.style.left="3em";    
    page.style.top="203vh";        
}
function cond3(){
    page = document.getElementById("port");
    page.addEventListener("mouseover", mouseOver);
    page.style.width="3em"; 
    page.style.position="absolute";
    page.style.left="3em";    
    page.style.top="100vh";    
}
function cond4(x){
    x.style.filter="grayscale(100%)";
 
} 
function cond5(x){
x.style.filter="none";
}

var myIndex = 0;
carousel();

function carousel() {
    var i;
    var x = document.getElementsByClassName("mySlides");
    for (i = 0; i < x.length; i++) {
       x[i].style.display = "none";
    }
    myIndex++;
    if (myIndex > x.length) {myIndex = 1}
    x[myIndex-1].style.display = "block";
    x[myIndex-1].style.height = "100vh";
    x[myIndex-1].style.position = "absolute";
    x[myIndex-1].style.top = "300vh";
    x[myIndex-1].style.width = "100%";
    setTimeout(carousel, 5000);
}
function cond6(){
    $('form[name="GBook"]').submit();
}

$(document).ready(function() {
    $( "#grab" ).draggable();
    $( "#grab2" ).draggable();
    $( "#grab3" ).draggable();
    $( "#grab4" ).draggable();
    $( "#grab6" ).draggable();
    $( "#grab7" ).draggable();
  } );
$(document).scroll(function() { 
  var y = $(this).scrollTop();
  if (y > 500) {
    $('#arrow').fadeIn();
    $('#tool').fadeIn();
   
  } else {
    $('#arrow').fadeOut();
    $('#tool').fadeOut();
  }
});
var myIndex2 = 0;
carousel2();

function carousel2() {
    var i;
    var x = document.getElementsByClassName("mySlides2");
    for (i = 0; i < x.length; i++) {
       x[i].style.display = "none";  
    }
    myIndex2++;
    if (myIndex2 > x.length) {myIndex2 = 1}    
    x[myIndex2-1].style.display = "block";  
    x[myIndex2-1].style.height = "100vh";
    x[myIndex2-1].style.position = "absolute";
    x[myIndex2-1].style.top = "300vh";
    x[myIndex2-1].style.width = "100%";
    setTimeout(carousel2, 2000); // Change image every 2 seconds
}





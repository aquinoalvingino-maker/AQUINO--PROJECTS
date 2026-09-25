// =========================
// Monthly Inventory Chart
// =========================

const salesChart = document.getElementById("salesChart");

if (salesChart) {

new Chart(salesChart, {

type: "bar",

data: {

labels: [

"Jan",

"Feb",

"Mar",

"Apr",

"May",

"Jun",

"Jul"

],

datasets: [

{

label: "Stock In",

data: [

120,

150,

180,

170,

210,

190,

230

],

backgroundColor: "#6B1020",

borderRadius: 8

},

{

label: "Stock Out",

data: [

80,

95,

110,

130,

150,

140,

180

],

backgroundColor: "#D9A5B3",

borderRadius: 8

}

]

},

options: {

responsive:true,

plugins:{

legend:{

position:'top'

}

}

}

});

}



// =========================
// Inventory Status Chart
// =========================

const pieChart = document.getElementById("pieChart");

if (pieChart){

new Chart(pieChart,{

type:"doughnut",

data:{

labels:[

"In Stock",

"Low Stock",

"Out of Stock"

],

datasets:[{

data:[75,20,5],

backgroundColor:[

"#6B1020",

"#C98A98",

"#E74C3C"

]

}]

},

options:{

responsive:true,

cutout:"65%"

}

});

}



// =========================
// Counter Animation
// =========================

const counters=document.querySelectorAll(".dashboard-card h3");

counters.forEach(counter=>{

const update=()=>{

const target=Number(counter.innerText);

const current=Number(counter.getAttribute("data-count"))||0;

const increment=target/50;

if(current<target){

const next=Math.ceil(current+increment);

counter.setAttribute("data-count",next);

counter.innerText=next;

setTimeout(update,20);

}else{

counter.innerText=target;

}

}

update();

});




// =========================
// Search Demo
// =========================

const searchInput=document.querySelector(".search input");

if(searchInput){

searchInput.addEventListener("keyup",function(){

let value=this.value.toLowerCase();

let rows=document.querySelectorAll("tbody tr");

rows.forEach(row=>{

row.style.display=row.innerText.toLowerCase().includes(value)

? ""

: "none";

});

});

}
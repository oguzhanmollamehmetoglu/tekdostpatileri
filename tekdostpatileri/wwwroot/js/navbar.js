const navlink = document.querySelectorAll('.nav-link');

navlink.forEach((item) => {
	item.addEventListener('click',(event) => {
         event.preventDefault();

         navlink.forEach((navlink) => {
         	navlink.classList.remove('active');
         });

         item.classList.add('active');

         const tabpaneId = item.querySelector('a').getAttribute('href');
         const tabpane = document.querySelector(tabpaneId);

         document.querySelectorAll('.tab-pane').forEach((tabpane) => {
             tabpane.classList.remove('active');
         });

         tabpane.classList.add('active');
	});
});

function myFunction() {
  var x = document.getElementById("myLinks");
  if (x.style.display === "block") {
    x.style.display = "none";
  } else {
    x.style.display = "block";
  }
}
